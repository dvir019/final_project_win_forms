using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
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
        private Process pythonProcess;

        private Thread receiveThread;

        private bool changedAndDidntSave;

        private EditsForm editsForm;

        private bool loadChange;

        /// <summary>
        /// Constructor of the class.
        /// Used for the host type of the ConnectOrHost.
        /// </summary>
        /// <param name="connectOrHost">The type of the connectOrHost</param>
        /// <param name="port">The port</param>
        /// <param name="client">The TcpClient socket</param>
        /// <param name="name">The name of the user</param>
        /// <param name="filePath">The full path to the file</param>
        public MainForm(ConnectOrHost connectOrHost, int port, TcpClient client, string name, string filePath, Process pythonProcess)
        {
            InitializeComponent();
            this.connectOrHost = connectOrHost;
            this.port = port;
            this.client = client;
            this.name = name;
            this.filePath = filePath;
            stream = client.GetStream();
            ip = Constants.MY_IP;
            this.pythonProcess = pythonProcess;

            previousText = "";
            serverChange = false;
            receiveThread = new Thread(ReceiveAllTime);
            stopAll = false;

            CheckForIllegalCrossThreadCalls = false;

            changedAndDidntSave = false;

            editsForm = new EditsForm();

            loadChange = false;
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
        public MainForm(ConnectOrHost connectOrHost, string ip, int port, TcpClient client, string name) : this(connectOrHost, port, client, name, "", null)
        {
            this.ip = ip;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            receiveThread.Start();
            //Closed += (s, args) => CloseSockets();

            if (connectOrHost == ConnectOrHost.Host)
            {
                if (File.ReadAllText(filePath) != "")
                {
                    loadChange = true;
                    rtb.LoadFile(filePath);
                    loadChange = false;
                }
                statusBarIpPort.Text = string.Format("      Ip: {0}, Port: {1}", GetLocalIPAddress(), port);
            }

            else
                DisableSaveButtons();
        }


        private void rtb_SelectionChanged(object sender, EventArgs e)
        {
            int line = 1 + rtb.GetLineFromCharIndex(rtb.GetFirstCharIndexOfCurrentLine());
            int column = 1 + rtb.SelectionStart - rtb.GetFirstCharIndexOfCurrentLine();
            statusStripLineColumn.Text = string.Format("Line: {0}, Column: {1}", line, column);
            UpdateToolStripButtonsAndComboBoxes();
        }

        private void rtb_TextChanged(object sender, EventArgs e)
        {
            if (!serverChange)
            {
                ConstructAndSendEdit();
                if (!loadChange)
                {
                    //string edit = string.Format("You ({0}) edited the file in {1}", name, DateTime.Now.ToString("HH:mm:ss"));
                    //editsForm.AddNewLine(edit);
                }
            }
            previousText = rtb.Text;
            changedAndDidntSave = true;

            
        }

        /// <summary>
        /// Handles the SizeChanged event of the form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
                return;
            //MessageBox.Show(string.Format("Height: {0}, Width: {1}", Height, Width));
            Rectangle screenRectangle = RectangleToScreen(ClientRectangle);

            int titleHeight = screenRectangle.Top - Top;

            rtb.Height = Height - menuStrip1.Height - toolStrip1.Height - statusStrip1.Height - titleHeight - 7;

            rtb.Width = ClientRectangle.Width - rtb.Location.X;

            int chatCurrentHeight = chatBox.Height;
            int chatNewHeight = Height - titleHeight - inputChatBox.Height - sendChatButton.Height - 100;
            chatBox.Height = chatNewHeight;
            int heightDiffernce = chatNewHeight - chatCurrentHeight;

            //MessageBox.Show(string.Format("dif: {0}\nrich: {1}->{2}\nbutton: {3}->{4}", heightDiffernce, richTextBox1.Location, new Point(richTextBox1.Location.X, richTextBox1.Location.Y+heightDiffernce), button1.Location, new Point(button1.Location.X, button1.Location.Y + heightDiffernce)));
            inputChatBox.Location = new Point(inputChatBox.Location.X, inputChatBox.Location.Y + heightDiffernce);
            sendChatButton.Location = new Point(sendChatButton.Location.X, sendChatButton.Location.Y + heightDiffernce);
        }


    }
}
