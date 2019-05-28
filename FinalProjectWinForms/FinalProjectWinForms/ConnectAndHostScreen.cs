using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectWinForms
{
    public partial class ConnectAndHostScreen : Form
    {
        public ConnectAndHostScreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void hostButton_Click(object sender, EventArgs e)
        {
            if (!CheckName(ConnectOrHost.Host))
                return;

        }

        private bool CheckName(ConnectOrHost connectOrHost)
        {
            if ((connectOrHost == ConnectOrHost.Connect && !connectNameTextBox.Text.All(char.IsLetterOrDigit)) || (connectOrHost == ConnectOrHost.Host && !hostNameTextBox.Text.All(char.IsLetterOrDigit)))
            {
                MessageBox.Show("Choose a valid name!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (!CheckName(ConnectOrHost.Connect))
                return;
        }
    }
}
