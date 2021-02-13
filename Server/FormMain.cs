using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using SocketTest;
using System.Text;

namespace SocketServer
{
    delegate void DelegateUpdateControls();
    delegate void DelegateAddToList(string data);

    public partial class FormMain : Form
    {
        private DelegateUpdateControls delgUpdateClient = null;
        private DelegateAddToList delgAddToRcvList = null;
        private Socket srvSocket = null;
        private Socket cliSocket = null;
        private readonly byte[] rcvBuff = new byte[4096];

#region Initialization
		public FormMain()
        {
            InitializeComponent();

            delgUpdateClient = new DelegateUpdateControls(UpdateClientStatus);
            delgAddToRcvList = new DelegateAddToList(AddRcvListItem);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                // initialize controls
                UpdateServerStatus();
                UpdateClientStatus();

                // init list of data type
                cbSendData.Items.Add("short");
                cbSendData.Items.Add("int");
                cbSendData.Items.Add("double");
                cbSendData.Items.Add("string");
                cbSendData.SelectedIndex = 3;

                // try to get local IP
                tbIPaddr.Text = "getting...";
                bool bFound = false;
                IPHostEntry local = Dns.GetHostEntry(Dns.GetHostName());
                foreach(IPAddress addr in local.AddressList)
                    if (addr.AddressFamily == AddressFamily.InterNetwork)
                    {
                        tbIPaddr.Text = addr.ToString();
                        bFound = true;
                        break;
                    }
                if ( !bFound )
                {
                    tbIPaddr.Text = "";
                    tbIPaddr.Enabled = true;
                    tbIPaddr.ReadOnly = false;
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
#endregion

#region Socket operations
        protected override void OnClosing(CancelEventArgs e)
        {
        // stop sockets
            CloseServer();
            CloseClient();

            base.OnClosing(e);
        }

        private void CloseServer()
        {
            if (srvSocket != null)
            {
                srvSocket.Close();
            }
            srvSocket = null;
        }

        private void CloseClient()
        {
            if (cliSocket != null && cliSocket.Connected)
            {
                cliSocket.Shutdown(SocketShutdown.Both);
                cliSocket.Close();
            }
            cliSocket = null;
        }

        // beware of thread safety in following methods
        // both OnAccept and OnReceive are called from worker thread -> do not dorectly access UI created by UI thread in them (e.i. do not access this and controls)
        public void OnAccept(IAsyncResult ar)
        {
            try
            {
                Socket listener = (Socket)ar.AsyncState;
                Socket newCliSocket = listener.EndAccept(ar);

                if (cliSocket != null && cliSocket.Connected &&
                    GM.ShowQuestionMessageBox(this, string.Format("New client tries to connect.{0}Close current connection and accept the new one?", Environment.NewLine)) != DialogResult.Yes)
                {
                    newCliSocket.Close();
                    newCliSocket = null;
                }
                else
                {
                    CloseClient();
                    cliSocket = newCliSocket;
                    cliSocket.Blocking = false;

                    cliSocket.BeginReceive(rcvBuff, 0, rcvBuff.Length, SocketFlags.None, new AsyncCallback(OnRecieve), cliSocket);
                }
            }
            catch (Exception ex)
            {
                if (srvSocket != null)
                    GM.ShowErrorMessageBox(this, "Error occured on server socket!", ex);
            }
            UpdateClientStatus();

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
                    // save to receive list
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < nRcv; i++)
                        sb.AppendFormat(" {0:X2}", rcvBuff[i]);

                    AddRcvListItem(sb.ToString());
                }
                else	// If no data was recieved then the connection is probably dead
                {
                    sock.Shutdown(SocketShutdown.Both);
                    sock.Close();

                    UpdateClientStatus();
                }
            }
            catch (Exception ex)
            {
                if (sock != null && sock.Connected)
                    GM.ShowErrorMessageBox(this, "Error occured during receiving data!", ex);
            }

            // restablish the callback
            if (sock != null && sock.Connected)
                sock.BeginReceive(rcvBuff, 0, rcvBuff.Length, SocketFlags.None, new AsyncCallback(OnRecieve), sock);
        }
#endregion

#region Methods updating UI controls
		private void UpdateServerStatus()
        {
            bool srvRunning = (srvSocket != null);

            spinIPport.Enabled = (!srvRunning);
            btnSrvCreate.Enabled = (!srvRunning);
            btnSrvClose.Enabled = (srvRunning);
        }

        private void UpdateClientStatus()
        {
            if (InvokeRequired) // ensure thread safety ~ this method can be called both from UI thread and worker thread
            {
                Invoke(delgUpdateClient);
                return;
            }

            bool cliRunning = (cliSocket != null && cliSocket.Connected);
            if (cliRunning)
            {
                tbCliLocaleIP.Text = cliSocket.LocalEndPoint.ToString();
                tbCliRemoteIP.Text = cliSocket.RemoteEndPoint.ToString();
            }
            else
            {
                tbCliLocaleIP.Text = " none";
                tbCliRemoteIP.Text = " none";
            }
            btnCliClose.Enabled = cliRunning;
            cbSendData.Enabled = cliRunning;
            tbSendData.Enabled = cliRunning;
            btnSend.Enabled = cliRunning;
        }

        private void AddRcvListItem(string itemText)
        {
            if (InvokeRequired) // ensure thread safety ~ this method can be called both from UI thread and worker thread
            {
                Invoke(delgAddToRcvList, itemText);
                return;
            }

            listRcv.SelectedIndex = listRcv.Items.Add((listRcv.Items.Count + 1) + ". " + itemText);
        }
#endregion

#region UI controls event handlers
		private void btnSrvCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (srvSocket != null)
                {
                    if (GM.ShowQuestionMessageBox(this, string.Format("Server already exists.{0}Do you wish to close it and create the new one?", Environment.NewLine)) != DialogResult.Yes)
                        return;

                    CloseServer();
                }

                // Create the listener socket in this machines IP address
//                IPEndPoint ep = new IPEndPoint(IPAddress.Any, (int)(spinIPport.Value));
//                srvSocket = new Socket(ep.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
//                srvSocket.Bind(ep);

                srvSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                srvSocket.Bind(new IPEndPoint(IPAddress.Parse(tbIPaddr.Text), (int)(spinIPport.Value)));

                srvSocket.Listen(10);

                // Setup a callback to be notified of connection requests
                srvSocket.BeginAccept(new AsyncCallback(OnAccept), srvSocket);      
            }
            catch(Exception ex)
            {
                GM.ShowErrorMessageBox(this, "Server initialization failed!", ex);
            }

            UpdateServerStatus();
        }

        private void btnSrvClose_Click(object sender, EventArgs e)
        {
            CloseServer();
            UpdateServerStatus();
        }

        private void btnCliClose_Click(object sender, EventArgs e)
        {
            CloseClient();
            UpdateClientStatus();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
			if ( cliSocket == null || !cliSocket.Connected )
			{
                GM.ShowErrorMessageBox(this, "No client connected!");
				return;
			}
			string s = tbSendData.Text;
			s.Trim();
			if ( s.Length < 1 )
			{
                GM.ShowErrorMessageBox(this, "No data specified!");
				tbSendData.Focus();
				return;
			}

            byte[] buff;
            switch ( cbSendData.Text )
			{
            case "short":
				try
				{
					short i = Convert.ToInt16(s);
					buff = BitConverter.GetBytes(i);
				}
				catch
				{
					GM.ShowErrorMessageBox(this, "Enter short!");
					tbSendData.Focus();
					tbSendData.SelectAll();
					return;
				}
				break;
            case "int":
				try
				{
					int i = Convert.ToInt32(s);
					buff = BitConverter.GetBytes(i);
				}
				catch
				{
                    GM.ShowErrorMessageBox(this, "Enter integer!");
					tbSendData.Focus();
					tbSendData.SelectAll();
					return;
				}
				break;
            case "double":
                try
                {
                    double d;
                    if ( !double.TryParse(s, out d) && !double.TryParse(s.Replace('.', ','), out d) )
                        d = Convert.ToDouble(s.Replace(',', '.'));
					buff = BitConverter.GetBytes(d);
				}
                catch 
                {
                    GM.ShowErrorMessageBox(this, "Enter double!");
					tbSendData.Focus();
					tbSendData.SelectAll();
					return;
				}
				break;
			default: 
				buff = Encoding.ASCII.GetBytes( s.ToCharArray() );
				break;
			}
		// send data
			cliSocket.Send(buff);
			
		// save to send list
			StringBuilder sb = new StringBuilder();
			for ( int i = 0; i<buff.Length; i++)
				sb.AppendFormat(" {0:X2}", buff[i]);

			listSend.Items.Add((listSend.Items.Count/2+1)+". buffer:"+sb);
			listSend.SelectedIndex = listSend.Items.Add("  as "+cbSendData.SelectedItem+": "+tbSendData.Text);
			
		// clear sent data
			tbSendData.Text = "";
        }

        private void btnSendClear_Click(object sender, EventArgs e)
        {
            listSend.Items.Clear();
        }

        private void btnRcvClear_Click(object sender, EventArgs e)
        {
            listRcv.Items.Clear();		
        }

        private void checkAlwaysTop_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = !TopMost;
        }
#endregion    
    }
}