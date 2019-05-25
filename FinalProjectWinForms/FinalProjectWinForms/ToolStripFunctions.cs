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

        #region Clipboard management

        /// <summary>
        /// Handles the Click event of the tsCut button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void tsCut_Click(object sender, EventArgs e)
        {
            rtb.Cut();
        }

        /// <summary>
        /// Handles the Click event of the tsCopy button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void tsCopy_Click(object sender, EventArgs e)
        {
            rtb.Copy();
        }

        /// <summary>
        /// Handles the Click event of the tsPaste button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void tsPaste_Click(object sender, EventArgs e)
        {
            rtb.Paste();
        }

        #endregion Clipboard management

        #region Undo/redo

        /// <summary>
        /// Handles the Click event of the tsUndo button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void tsUndo_Click(object sender, EventArgs e)
        {
            rtb.Undo();
        }

        /// <summary>
        /// Handles the Click event of the tsRedo button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void tsRedo_Click(object sender, EventArgs e)
        {
            rtb.Redo();
        }

        #endregion Undo/Redo
    }
}
