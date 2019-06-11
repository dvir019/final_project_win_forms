using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectWinForms
{
    public partial class ConnectAndHostScreen : Form
    {
        private void connectButton_Click(object sender, EventArgs e)
        {
            if (!CheckName(ConnectOrHost.Connect))
                return;
            if (!CheckIpAddress())
                return;
            if (!CheckPort(ConnectOrHost.Connect))
                return;
            if (!ConnectToServer())
                return;

        }

        private bool ConnectToServer()
        {
            try
            {
                TcpClient client = new TcpClient(connectIpAddress.Text, 5555);
                tcpClient = client;
                networkStream = client.GetStream();
                return true;
            }
            catch
            {
                MessageBox.Show("Can't connect to host", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Checks if the IP address is valid.
        /// </summary>
        /// <returns>True if it is, else false</returns>
        private bool CheckIpAddress()
        {
            IPAddress ip;
            if (!IPAddress.TryParse(connectIpAddress.Text, out ip))
            {
                MessageBox.Show("Invalid IP address", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

    }
}
