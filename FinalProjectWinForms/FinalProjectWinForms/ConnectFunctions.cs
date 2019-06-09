using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectWinForms
{
    public partial class ConnectAndHostScreen : Form
    {
        private bool ConnectToServer()
        {
            try
            {
                TcpClient client = new TcpClient(connectIpAddress.Text, 5555);
                tcpClient = client;
                networkStream = client.GetStream();
                MessageBox.Show("connected");
                return true;
            }
            catch
            {
                MessageBox.Show("Can't connect to host", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}
