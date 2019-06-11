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
        private TcpClient tcpClient;
        private NetworkStream networkStream;

        public ConnectAndHostScreen()
        {
            InitializeComponent();
            tcpClient = null;
            networkStream = null;
        }

        /// <summary>
        /// Checks if the name entered is valid.
        /// </summary>
        /// <param name="connectOrHost">Connect or host</param>
        /// <returns>true if it's valid, else false</returns>
        private bool CheckName(ConnectOrHost connectOrHost)
        {
            if (connectOrHost == ConnectOrHost.Connect)
            {
                if (connectNameTextBox.Text == "" || !connectNameTextBox.Text.All(char.IsLetterOrDigit))
                {
                    MessageBox.Show("Choose a valid name, contains only letters ot digits!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                return true;
            }
            if (hostNameTextBox.Text == "" || !hostNameTextBox.Text.All(char.IsLetterOrDigit))
            {
                MessageBox.Show("Choose a valid name, contains only letters ot digits!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Checks if the port entered is valid.
        /// </summary>
        /// <param name="connectOrHost">Connect or host</param>
        /// <returns>true if it's valid, else false</returns>
        private bool CheckPort(ConnectOrHost connectOrHost, out int port)
        {
            if (connectOrHost == ConnectOrHost.Connect)
            {
                int connectPort;
                bool isConnectPortNumber = int.TryParse(connectPortTextBox.Text, out connectPort);
                if (isConnectPortNumber && connectPort >= Constants.PORT_MIN_VALUE && connectPort <= Constants.PORT_MAX_VALUE)
                {
                    port = connectPort;
                    return true;
                }
                MessageBox.Show(string.Format("Choose a valid port, a number between {0}-{1}", Constants.PORT_MIN_VALUE, Constants.PORT_MAX_VALUE), "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                port = 0;
                return false;
            }
            int hostPort;
            bool isHostPortNumber = int.TryParse(hostPortTextBox.Text, out hostPort);
            if (isHostPortNumber && hostPort >= Constants.PORT_MIN_VALUE && hostPort <= Constants.PORT_MAX_VALUE)
            {
                port = hostPort;
                return true;
            }
            MessageBox.Show(string.Format("Choose a valid port, a number between {0}-{1}", Constants.PORT_MIN_VALUE, Constants.PORT_MAX_VALUE), "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            port = 0;
            return false;
        }



        private void ConnectAndHostScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
