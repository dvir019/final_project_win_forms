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
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connectOrHost == ConnectOrHost.Host && changedAndDidntSave)
            {
                DialogResult saveResult = MessageBox.Show("Do you want to save the file?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (saveResult == DialogResult.Yes)
                    SaveFile();
                if (saveResult == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseSockets();
        }
    }
}
