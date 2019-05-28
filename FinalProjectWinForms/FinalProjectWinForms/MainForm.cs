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
    public partial class MainForm : Form
    {
        private string oldText;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            oldText = rtb.Text;
        }

        private void rtb_TextChanged(object sender, EventArgs e)
        {
            Text = rtb.SelectionStart.ToString();
            int differenceLength = oldText.Length - rtb.Text.Length;
            if (differenceLength<0)
                MessageBox.Show(string.Format("Add {0}->{1}", rtb.SelectionStart+differenceLength, rtb.SelectionStart));
            else if (differenceLength>0)
                MessageBox.Show(string.Format("Remove {0}->{1}", rtb.SelectionStart + differenceLength, rtb.SelectionStart));
            else
                MessageBox.Show(string.Format("Style {0}->{1}", rtb.SelectionStart + differenceLength, rtb.SelectionStart));
            oldText = rtb.Text;

        }
    }
}
