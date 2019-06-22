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
    public partial class EditsForm : Form
    {
        public EditsForm()
        {
            InitializeComponent();
        }

        private void EditsForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Adds a new line to the textBox.
        /// </summary>
        /// <param name="text">The text of the new line</param>
        public void AddNewLine(string text)
        {
            if (editsTextBox.Text.Trim() != "")
                editsTextBox.AppendText("\n");
            editsTextBox.AppendText(text);
        }
    }
}
