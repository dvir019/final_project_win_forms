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
        public MainForm()
        {
            InitializeComponent();
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
