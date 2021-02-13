using SocketTest;
using System;
using System.ComponentModel;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace SocketResender
{
    delegate void DelegateUpdateControls();

    public partial class FormMain : Form
    {
        private DelegateUpdateControls delgUpdateServerRemote = null;
        private DelegateUpdateControls delgUpdateClientLocale = null;
        private Socket srvSocket = null;
        private Socket srvRemoteSocket = null;
        private Socket cliSocket = null;
        private readonly byte[] rcvBuff = new byte[4096];

        public FormMain()
        {
            InitializeComponent();

            delgUpdateServerRemote = new DelegateUpdateControls(ServerRemoteUpdateStatus);
            delgUpdateClientLocale = new DelegateUpdateControls(ClientLocaleUpdateStatus);
        }
        private void FormMain_Load(object sender,EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                // initialize controls
                ServerUpdateStatus();
                ServerRemoteUpdateStatus();
                ClientLocaleUpdateStatus();

                // try to get local IP
                tbServerIPaddr.Text = "getting...";
                bool bFound = false;
                IPHostEntry local = Dns.GetHostEntry(Dns.GetHostName());
                foreach(IPAddress addr in local.AddressList)
                    if (addr.AddressFamily == AddressFamily.InterNetwork)
                    {
                        tbClientIPaddr.Text = tbServerIPaddr.Text = addr.ToString();
                        bFound = true;
                        break;
                    }
                if ( !bFound )
                {
                    tbServerIPaddr.Text = "";
                    tbServerIPaddr.Enabled = true;
                    tbServerIPaddr.ReadOnly = false;
                }
            }
            catch(Exception ex)
            {
                GM.ShowErrorMessageBox(this, "Error occured during application's initialization", ex);
            }
            finally 
            { 
                Cursor = Cursors.Default; 
            }
        }
#region Socket operations
        protected override void OnClosing(CancelEventArgs e)
        {
        // stop sockets
            ServerClose();
            ServerRemoteClose();

            ClientClose();

            base.OnClosing(e);
        }
        private void ServerClose()
        {
            if (srvSocket != null)
                srvSocket.Close();

            srvSocket = null;
        }
        private void ServerRemoteClose()
        {
            if (srvRemoteSocket != null && srvRemoteSocket.Connected)
            {
                srvRemoteSocket.Shutdown(SocketShutdown.Both);
                srvRemoteSocket.Close();
            }
            srvRemoteSocket = null;
        }
        private void ClientClose()
        {
            if (cliSocket != null && cliSocket.Connected)
            {
                cliSocket.Shutdown(SocketShutdown.Both);
                cliSocket.Close();
            }
            cliSocket = null;
        }

        // beware of thread safety in following methods
        // both OnAccept and OnReceive are called from worker thread -> do not directly access UI created by UI thread in them (e.i. do not access this and controls)
        public void OnAccept(IAsyncResult ar)
        {
            try
            {
                Socket listener = (Socket)ar.AsyncState;
                Socket newSrvRemoteSocket = listener.EndAccept(ar);

                if (srvRemoteSocket != null && srvRemoteSocket.Connected &&
                    GM.ShowQuestionMessageBox(this, string.Format("New client tries to connect.{0}Close current connection and accept the new one?", Environment.NewLine)) != DialogResult.Yes)
                {
                    newSrvRemoteSocket.Close();
                    newSrvRemoteSocket = null;
                }
                else
                {
                    ServerRemoteClose();
                    srvRemoteSocket = newSrvRemoteSocket;
                    srvRemoteSocket.Blocking = false;

                    srvRemoteSocket.BeginReceive(rcvBuff, 0, rcvBuff.Length, SocketFlags.None, new AsyncCallback(OnRecieve), srvRemoteSocket);
                }
            }
            catch (Exception ex)
            {
                if (srvSocket != null)
                    GM.ShowErrorMessageBox(this, "Error occured on server socket!", ex);
            }
            ServerRemoteUpdateStatus();

            // if server is not closed, continue accepting
            if (srvSocket != null)
                srvSocket.BeginAccept(new AsyncCallback(OnAccept), srvSocket);
        }

        public void OnRecieve(IAsyncResult ar)
        {
            // Socket was the passed in object
            Socket sock = (Socket)ar.AsyncState;

            // Check if we got any data
            try
            {
                int nRcv = sock.EndReceive(ar);
                if (nRcv > 0)
                {
                    if ( cliSocket != null && srvRemoteSocket != null )
                    {
                        if ( sock == cliSocket )
                            srvRemoteSocket.Send(rcvBuff, nRcv, SocketFlags.None);
                        else
                            cliSocket.Send(rcvBuff, nRcv, SocketFlags.None);
                    }
                }
                else	// If no data was recieved then the connection is probably dead
                {
                    sock.Shutdown(SocketShutdown.Both);
                    sock.Close();

                    ServerRemoteUpdateStatus();
                    ClientLocaleUpdateStatus();
                }
            }
            catch (Exception ex)
            {
                if (sock != null && sock.Connected)
                    GM.ShowErrorMessageBox(this, "Error occured when receiving data!", ex);
            }

            // If the connection is still usable restablish the callback
            if (sock != null && sock.Connected)
                sock.BeginReceive(rcvBuff, 0, rcvBuff.Length, SocketFlags.None, new AsyncCallback(OnRecieve), sock);
        }
#endregion

#region Methods updating UI controls
		private void ServerUpdateStatus()
        {
            bool srvRunning = (srvSocket != null);

            spinServerIPport.Enabled = (!srvRunning);
            btnServerCreate.Enabled = (!srvRunning);
            btnServerClose.Enabled = (srvRunning);
        }
        private void ServerRemoteUpdateStatus()
        {
            if (InvokeRequired) // ensure thread safety ~ this method can be called both from UI thread and worker thread
            {
                Invoke(delgUpdateServerRemote);
                return;
            }

            bool cliRunning = (srvRemoteSocket != null && srvRemoteSocket.Connected);
            if (cliRunning)
                tbServerRemoteIP.Text = srvRemoteSocket.RemoteEndPoint.ToString();
            else
                tbServerRemoteIP.Text = " none";
        }
        private void ClientLocaleUpdateStatus()
        {
            if (InvokeRequired) // ensure thread safety ~ this method can be called both from UI thread and worker thread
            {
                Invoke(delgUpdateClientLocale);
                return;
            }
            bool connExist = (cliSocket != null && cliSocket.Connected);
            if ( connExist )
                tbClientLocaleIP.Text = cliSocket.LocalEndPoint.ToString();
            else
                tbClientLocaleIP.Text = " none";
        }
#endregion

#region server handlers
        private void btnServerCreate_Click(object sender,EventArgs e)
        {
            try
            {
                if(srvSocket != null)
                {
                    if(GM.ShowQuestionMessageBox(this, string.Format("Server already exists.{0}Do you wish to close it and create the new one?", Environment.NewLine)) != DialogResult.Yes)
                        return;

                    ServerClose();
                }

                // Create the listener socket in this machines IP address
                //                IPEndPoint ep = new IPEndPoint(IPAddress.Any, (int)(spinIPport.Value));
                //                srvSocket = new Socket(ep.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                //                srvSocket.Bind(ep);

                srvSocket = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
                srvSocket.Bind(new IPEndPoint(IPAddress.Parse(tbServerIPaddr.Text),(int)(spinServerIPport.Value)));

                srvSocket.Listen(10);

                // Setup a callback to be notified of connection requests
                srvSocket.BeginAccept(new AsyncCallback(OnAccept),srvSocket);
            }
            catch(Exception ex)
            {
                GM.ShowErrorMessageBox(this, "Server initialization failed!", ex);
            }

            ServerUpdateStatus();

        }
        private void btnServerClose_Click(object sender,EventArgs e)
        {
            ServerClose();
            ServerUpdateStatus();
        }
        private void btnServerRemoteClose_Click(object sender,EventArgs e)
        {
            ServerRemoteClose();
            ServerRemoteUpdateStatus();
        }
#endregion

#region client handlers
        private void btnClientConnect_Click(object sender,EventArgs e)
        {
            // check current connection
            if (cliSocket != null && cliSocket.Connected)
            {
                if (GM.ShowQuestionMessageBox(this, string.Format("You are currently connected.{0}Close current connection and create the new one?", Environment.NewLine)) != DialogResult.Yes)
                    return;

                ClientClose();
            }

            // connect to server
            Cursor = Cursors.WaitCursor;
            try
            {
                cliSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                cliSocket.Connect(new IPEndPoint(IPAddress.Parse(tbClientIPaddr.Text), (int)(nudClientIPPort.Value)));
                cliSocket.Blocking = false;

                cliSocket.BeginReceive(rcvBuff, 0, rcvBuff.Length, SocketFlags.None, new AsyncCallback(OnRecieve), cliSocket);
            }
            catch (Exception ex)
            {
                GM.ShowErrorMessageBox(this, "Creating connection failed!", ex);
                ClientClose();
                tbClientIPaddr.Focus();
                tbClientIPaddr.SelectAll();
            }
            finally
            {
                Cursor = Cursors.Default;
            }
            ClientLocaleUpdateStatus();
        }
        private void btnClientRemoteClose_Click(object sender,EventArgs e)
        {
            ClientClose();
            ClientLocaleUpdateStatus();
        }
#endregion

        private void checkAlwaysTop_CheckedChanged(object sender,EventArgs e)
        {
            TopMost = !TopMost;
        }
    }
}
