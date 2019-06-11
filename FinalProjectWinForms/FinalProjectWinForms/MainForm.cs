using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectWinForms
{
    public partial class MainForm : Form
    {
        private ConnectOrHost connectOrHost;
        private string ip;
        private int port;
        private TcpClient client;
        private NetworkStream stream;
        private string name;
        private string filePath;


        /// <summary>
        /// Constructor of the class.
        /// Used for the host type of the ConnectOrHost.
        /// </summary>
        /// <param name="connectOrHost">The type of the connectOrHost</param>
        /// <param name="port">The port</param>
        /// <param name="client">The TcpClient socket</param>
        /// <param name="name">The name of the user</param>
        /// <param name="filePath">The full path to the file</param>
        public MainForm(ConnectOrHost connectOrHost, int port, TcpClient client, string name, string filePath)
        {
            InitializeComponent();
            this.connectOrHost = connectOrHost;
            this.port = port;
            this.client = client;
            this.name = name;
            this.filePath = filePath;
            stream = client.GetStream();
            ip = Constants.MY_IP;
        }

        /// <summary>
        /// Constructor of the class.
        /// Used for the connect type of the ConnectOrHost.
        /// </summary>
        /// <param name="connectOrHost">The type of the connectOrHost</param>
        /// <param name="ip"></param>
        /// <param name="port">The port</param>
        /// <param name="client">The TcpClient socket</param>
        /// <param name="name">The name of the user</param>
        public MainForm(ConnectOrHost connectOrHost, string ip, int port, TcpClient client, string name) : this(connectOrHost, port, client, name, "")
        {
            this.ip = ip;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void rtb_SelectionChanged(object sender, EventArgs e)
        {
            int line = 1 + rtb.GetLineFromCharIndex(rtb.GetFirstCharIndexOfCurrentLine());
            int column = 1 + rtb.SelectionStart - rtb.GetFirstCharIndexOfCurrentLine();
            lineColumnLabel.Text = string.Format("Line: {0}, Column: {1}", line, column);
            UpdateToolStripButtonsAndComboBoxes();
        }
    }
}
