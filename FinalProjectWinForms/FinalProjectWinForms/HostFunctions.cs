using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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
                File.Create(fullPath);
                return fullPath;
            }
            return "";
        }

        private string OpenFile()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = string.Format("RTF files (*{0})|*{0}", Constants.RTF_EXTENSION);
            if (fileDialog.ShowDialog()==DialogResult.OK)
            {
                return fileDialog.FileName;
            }
            return "";
        }
    }
}
