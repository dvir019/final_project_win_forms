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
        /// Handles the Click event of the toolStripCut button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void toolStripCut_Click(object sender, EventArgs e)
        {
            rtb.Cut();
        }

        /// <summary>
        /// Handles the Click event of the toolStripCopy button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void toolStripCopy_Click(object sender, EventArgs e)
        {
            rtb.Copy();
        }

        /// <summary>
        /// Handles the Click event of the toolStripPaste button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void toolStripPaste_Click(object sender, EventArgs e)
        {
            rtb.Paste();
        }

        #endregion Clipboard management

        #region Undo/redo

        /// <summary>
        /// Handles the Click event of the toolStripUndo button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void toolStripUndo_Click(object sender, EventArgs e)
        {
            if (rtb.CanUndo)
                rtb.Undo();
            else
                toolStripUndo.Enabled = false;
        }

        /// <summary>
        /// Handles the Click event of the toolStripRedo button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void toolStripRedo_Click(object sender, EventArgs e)
        {
            if (rtb.CanRedo)
                rtb.Redo();
            else
                toolStripRedo.Enabled = false;
        }

        #endregion Undo/Redo

        #region Font style management

        /// <summary>
        /// Handles the Click event of the tsBold control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void tsBold_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(!rtb.SelectionFont.Bold, rtb.SelectionFont.Italic, rtb.SelectionFont.Underline, rtb.SelectionFont.Strikeout);
        }

        /// <summary>
        /// Handles the Click event of the tsItalic control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void tsItalic_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(rtb.SelectionFont.Bold, !rtb.SelectionFont.Italic, rtb.SelectionFont.Underline, rtb.SelectionFont.Strikeout);
        }

        /// <summary>
        /// Handles the Click event of the tsUnderline control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void tsUnderline_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(rtb.SelectionFont.Bold, rtb.SelectionFont.Italic, !rtb.SelectionFont.Underline, rtb.SelectionFont.Strikeout);
        }

        /// <summary>
        /// Handles the Click event of the tsStrikeout control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void tsStrikeout_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(rtb.SelectionFont.Bold, rtb.SelectionFont.Italic, rtb.SelectionFont.Underline, !rtb.SelectionFont.Strikeout);
        }

        /// <summary>
        /// Changes the font style.
        /// </summary>
        /// <param name="fontBold">if set to <c>true</c> [font bold].</param>
        /// <param name="fontItalic">if set to <c>true</c> [font italic].</param>
        /// <param name="fontUnderline">if set to <c>true</c> [font underline].</param>
        /// <param name="fontStrikeout">if set to <c>true</c> [font strikeout].</param>
        private void ChangeFontStyle(bool fontBold, bool fontItalic, bool fontUnderline, bool fontStrikeout)
        {
            FontStyle newFontStyle = FontStyle.Regular;

            if (fontBold)
                newFontStyle |= FontStyle.Bold;
            if (fontItalic)
                newFontStyle |= FontStyle.Italic;
            if (fontUnderline)
                newFontStyle |= FontStyle.Underline;
            if (fontStrikeout)
                newFontStyle |= FontStyle.Strikeout;

            rtb.SelectionFont = new Font(rtb.SelectionFont, newFontStyle);
            //rtb_SelectionChanged(rtb, new EventArgs());
        }

#endregion Font style management
    }
}
