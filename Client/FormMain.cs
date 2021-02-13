using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using SocketTest;
using System.Text;

namespace SocketClient
{
    delegate void DelegateUpdateControls();
    delegate void DelegateAddToList(string data);

    public partial class FormMain : Form
    {
        private DelegateUpdateControls delgUpdateCtrl = null;
        private DelegateAddToList delgAddToRcvList = null;
        private Socket cliSocket = null;
        private readonly byte[] rcvBuff = new byte[4096];

        public FormMain()
        {
            InitializeComponent();

            delgUpdateCtrl = new DelegateUpdateControls(UpdateCtrlStatus);
            delgAddToRcvList = new DelegateAddToList(AddRcvListItem);
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                // initialize controls
                UpdateCtrlStatus();

                // init list of data type
                cbSendData.Items.Add("short");
                cbSendData.Items.Add("int");
                cbSendData.Items.Add("double");
                cbSendData.Items.Add("string");
                cbSendData.SelectedIndex = 3;

                // try to get local IP
                foreach(IPAddress addr in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
                    if (addr.AddressFamily == AddressFamily.InterNetwork)
                    {
                        tbIPaddr.Text = addr.ToString();
                        break;
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
            // stop socket
            CloseConnection();

            base.OnClosing(e);
        }

        private void CloseConnection()
        {
            if (cliSocket != null && cliSocket.Connected)
            {
                cliSocket.Shutdown(SocketShutdown.Both);
                cliSocket.Close();
            }
            cliSocket = null;
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

                    UpdateCtrlStatus();
                }
            }
            catch (Exception ex)
            {
                if (sock != null && sock.Connected)
                    GM.ShowErrorMessageBox(this, "Error occured during receiving data", ex);
            }

            // If the connection is still usable restablish the callback
            if (sock != null && sock.Connected)
                sock.BeginReceive(rcvBuff, 0, rcvBuff.Length, SocketFlags.None, new AsyncCallback(OnRecieve), sock);
        }
#endregion

#region Methods updating UI controls
        private void UpdateCtrlStatus()
        {
            if (InvokeRequired) // ensure thread safety ~ this method can be called both from UI thread and worker thread
            {
                Invoke(delgUpdateCtrl);
                return;
            }
            bool connExist = (cliSocket != null && cliSocket.Connected);
            if ( connExist )
            {
                tbCliLocaleIP.Text = cliSocket.LocalEndPoint.ToString();
                tbCliRemoteIP.Text = cliSocket.RemoteEndPoint.ToString();
            }
            else
            {
                tbCliLocaleIP.Text = " none";
                tbCliRemoteIP.Text = " none";
            }
            tbIPaddr.Enabled = !connExist;
            spinIPport.Enabled = !connExist;
            btnConnect.Enabled = !connExist;
            btnClose.Enabled = connExist;

            cbSendData.Enabled = connExist;
            tbSendData.Enabled = connExist;
            btnSend.Enabled = connExist;
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
        private void btnConnect_Click(object sender, EventArgs e)
        {
            // check current connection
            if (cliSocket != null && cliSocket.Connected)
            {
                if ( GM.ShowQuestionMessageBox(this, string.Format("You are currently connected.{0}Close current connection and create the new one?", Environment.NewLine)) != DialogResult.Yes)
                    return;

                CloseConnection();
            }

            // connect to server
            Cursor = Cursors.WaitCursor;
            try
            {
                cliSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                cliSocket.Connect(new IPEndPoint(IPAddress.Parse(tbIPaddr.Text), (int)(spinIPport.Value)));
                cliSocket.Blocking = false;

                cliSocket.BeginReceive(rcvBuff, 0, rcvBuff.Length, SocketFlags.None, new AsyncCallback(OnRecieve), cliSocket);
            }
            catch (Exception ex)
            {
                GM.ShowErrorMessageBox(this, "Creating connection failed!", ex);
                CloseConnection();
                tbIPaddr.Focus();
                tbIPaddr.SelectAll();
            }
            finally
            {
                Cursor = Cursors.Default;
            }
            UpdateCtrlStatus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseConnection();
            UpdateCtrlStatus();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (cliSocket == null || !cliSocket.Connected)
            {
                GM.ShowErrorMessageBox(this, "No client connected!");
                return;
            }
            string strToSend = tbSendData.Text;
            if ( string.IsNullOrEmpty(strToSend))
            {
                GM.ShowErrorMessageBox(this, "No data specified!");
                tbSendData.Focus();
                return;
            }

            byte[] buff;
            switch (cbSendData.Text)
            {
            case "short":
                try
                {
                    short i = Convert.ToInt16(strToSend);
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
                    int i = Convert.ToInt32(strToSend);
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
                    if ( !double.TryParse(strToSend, out d) && !double.TryParse(strToSend.Replace('.', ','), out d) )
                        d = Convert.ToDouble(strToSend.Replace(',', '.'));

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
                buff = Encoding.ASCII.GetBytes(strToSend.ToCharArray());
                break;
            }
            // send data
            cliSocket.Send(buff);

            // save to send list
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < buff.Length; i++)
                sb.AppendFormat(" {0:X2}", buff[i]);

            listSend.Items.Add((listSend.Items.Count / 2 + 1) + ". buffer:" + sb);
            listSend.SelectedIndex = listSend.Items.Add("  as " + cbSendData.SelectedItem + ": " + tbSendData.Text);

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