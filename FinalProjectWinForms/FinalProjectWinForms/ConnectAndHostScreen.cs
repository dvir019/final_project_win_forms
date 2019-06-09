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
                    MessageBox.Show("Choose a valid name, with only letters ot digits!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                return true;
            }
            if (hostNameTextBox.Text == "" || !hostNameTextBox.Text.All(char.IsLetterOrDigit))
            {
                MessageBox.Show("Choose a valid name, with only letters ot digits!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }


        private void connectButton_Click(object sender, EventArgs e)
        {
            if (!CheckName(ConnectOrHost.Connect))
                return;
            ConnectToServer();

        }


        private void ConnectAndHostScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
