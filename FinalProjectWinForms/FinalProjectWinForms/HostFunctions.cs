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
    public partial class ConnectAndHostScreen : Form
    {
  
        private void hostButton_Click(object sender, EventArgs e)
        {
            if (!CheckName(ConnectOrHost.Host))
                return;
            int port;
            if (!CheckPort(ConnectOrHost.Host, out port))
                return;
            string path = "";
            if (newRadioButton.Checked)
                path = NewFile();
            else if (openRadioButton.Checked)
                path = OpenFile();
            if (path == "")
                return;

            Process pythonProcess = PythonProcess(port);

            if (!ConnectToPython(port))
            {
                MessageBox.Show("Test");
                try
                {
                    pythonProcess.Kill();
                }
                catch
                { }
                return;
            }

            MainForm mainForm = new MainForm(ConnectOrHost.Host, port, tcpClient, hostNameTextBox.Text, path, pythonProcess);
            mainForm.Closed += (s, args) => Close();
            mainForm.Show();
            Hide();
        }

        private bool ConnectToPython(int port)
        {
            try
            {
                TcpClient client = new TcpClient(Constants.MY_IP, port);
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

        private string SelectFolder()
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            if (folderDialog.ShowDialog()==DialogResult.OK)
                return folderDialog.SelectedPath;
            return "";
        }

        private string NewFile()
        {
            string folder = SelectFolder();
            if (folder == "")
                return "";
            InputForm inputForm = new InputForm(folder);
            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                string fullPath = inputForm.FullPath;
                FileStream fileStream = File.Create(fullPath);
                fileStream.Close();
                return fullPath;
            }
            return "";
        }

        /// <summary>
        /// Opens a file dialog to open a certain rtf file.
        /// </summary>
        /// <returns>The path to the file</returns>
        private string OpenFile()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = string.Format("RTF files (*{0})|*{0}", Constants.RTF_EXTENSION);
            fileDialog.FileOk += CheckFileExtension;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                return fileDialog.FileName;
            }
            return "";
        }

        /// <summary>
        /// Checks the extension of the file.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.ComponentModel.CancelEventArgs"/> instance containing the event data.</param>
        private void CheckFileExtension(object sender, CancelEventArgs e)
        {
            if (sender is OpenFileDialog)
            {
                OpenFileDialog fileDialog = (OpenFileDialog)sender;
                FileInfo file = new FileInfo(fileDialog.FileName);
                if (file.Extension != Constants.RTF_EXTENSION)
                {
                    MessageBox.Show("The file must be a rtf file!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Cancel = true;
                }
            }
        }

        /// <summary>
        /// Starts the python procces.
        /// </summary>
        /// <param name="port">The port for the server</param>
        /// <returns></returns>
        private Process PythonProcess(int port)
        {
            Process pythonProcess = new Process();
            //pythonProcess.StartInfo.RedirectStandardOutput = true;
            //pythonProcess.StartInfo.UseShellExecute = false;
            //pythonProcess.StartInfo.CreateNoWindow = true;
            pythonProcess.StartInfo = new ProcessStartInfo(@"C:\Users\Horim\Desktop\forScreenshots.py");
            pythonProcess.StartInfo.Arguments = port.ToString();
            //pythonProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            pythonProcess.Start();
            Thread.Sleep(200);
            return pythonProcess;
        }
    }
}
