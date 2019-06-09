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
            if (newRadioButton.Checked)
            {
                NewFile();
            }
            else if (openRadioButton.Checked)
            {
                OpenFile();
            }
        }

        private string SelectFolder()
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            if (folderDialog.ShowDialog()==DialogResult.OK)
                return folderDialog.SelectedPath;
            return "";
        }

        private void NewFile()
        {
            string folder = SelectFolder();
            if (folder == "")
                return;
            InputForm inputForm = new InputForm(folder);
            if (inputForm.ShowDialog() == DialogResult.OK)
                File.Create(inputForm.FullPath);
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
