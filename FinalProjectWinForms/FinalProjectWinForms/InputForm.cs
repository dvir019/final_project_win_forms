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
    public partial class InputForm : Form
    {
        private string path;
        private string extension = Constants.RTF_EXTENSION;

        public InputForm(string path)
        {
            InitializeComponent();
            this.path = path;
            cancelButton.DialogResult = DialogResult.Cancel;
        }

        private void InputForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Gets the input and the extension.
        /// </summary>
        public string Input { get { return inputBox.Text + extension; } }

        /// <summary>
        /// Gets the full path to the file
        /// </summary>
        public string FullPath { get { return Path.Combine(path, Input); } }

        /// <summary>
        /// Checks if the name is valid and not taken.
        /// </summary>
        private void OkOrEnter()
        {
            string trimInput = inputBox.Text.Trim();
            if (trimInput == string.Empty || (trimInput + extension).IndexOfAny(Path.GetInvalidFileNameChars()) != -1)
                MessageBox.Show("Invalid Name!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (PathExists(Path.Combine(path, trimInput + extension)))
                MessageBox.Show("Name already exists!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        /// <summary>
        /// Checks if path is already exists.
        /// </summary>
        /// <param name="path">The file path</param>
        /// <returns></returns>
        private bool PathExists(string path)
        {
            return File.Exists(path);
        }

        /// <summary>
        /// Handles the Click event of the OK button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void okButton_Click(object sender, EventArgs e)
        {
            OkOrEnter();
        }

        /// <summary>
        /// Handles the KeyPress event of the input textbox.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void inputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                OkOrEnter();
        }
    }
}
