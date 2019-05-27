﻿using System;
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
            if (!rtb.CanUndo)
            {
                toolStripUndo.Enabled = false;
                contextMenuStripUndo.Enabled = false;
            }
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
            if (!rtb.CanRedo)
            {
                toolStripRedo.Enabled = false;
                contextMenuStripRedo.Enabled = false;
            }
        }

        #endregion Undo/Redo

        #region Font style management

        /// <summary>
        /// Handles the Click event of the toolStripBold button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void toolStripBold_Click(object sender, EventArgs e)
        {
            Font selectionFont = rtb.SelectionFont;
            ChangeFontStyle(!selectionFont.Bold, selectionFont.Italic, selectionFont.Underline, selectionFont.Strikeout);
        }

        /// <summary>
        /// Handles the Click event of the toolStripItalic button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void toolStripItalic_Click(object sender, EventArgs e)
        {
            Font selectionFont = rtb.SelectionFont;
            ChangeFontStyle(selectionFont.Bold, !selectionFont.Italic, selectionFont.Underline, selectionFont.Strikeout);
        }

        /// <summary>
        /// Handles the Click event of the toolStripUnderline button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void toolStripUnderline_Click(object sender, EventArgs e)
        {
            Font selectionFont = rtb.SelectionFont;
            ChangeFontStyle(selectionFont.Bold, selectionFont.Italic, !selectionFont.Underline, selectionFont.Strikeout);
        }

        /// <summary>
        /// Handles the Click event of the toolStripStrikeout button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void toolStripStrikeout_Click(object sender, EventArgs e)
        {
            Font selectionFont = rtb.SelectionFont;
            ChangeFontStyle(selectionFont.Bold, selectionFont.Italic, selectionFont.Underline, !selectionFont.Strikeout);
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
            CheckAndUncheckStyleButtons();
        }

        private void CheckAndUncheckStyleButtons()
        {
            Font selectionFont = rtb.SelectionFont;
            if (selectionFont != null)
            {
                toolStripBold.Checked = selectionFont.Bold;
                toolStripItalic.Checked = selectionFont.Italic;
                toolStripUnderline.Checked = selectionFont.Underline;
                toolStripStrikeout.Checked = selectionFont.Strikeout;
            }
        }

        #endregion Font style management

        #region Alignment management

        /// <summary>
        /// Handles the Click event of the toolStripLeft button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void toolStripLeft_Click(object sender, EventArgs e)
        {
            rtb.SelectionAlignment = HorizontalAlignment.Left;
            CheckAndUncheckAlignmentButtons();
        }

        /// <summary>
        /// Handles the Click event of the toolStripCenter button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void toolStripCenter_Click(object sender, EventArgs e)
        {
            rtb.SelectionAlignment = HorizontalAlignment.Center;
            CheckAndUncheckAlignmentButtons();
        }

        /// <summary>
        /// Handles the Click event of the toolStripRight button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void toolStripRight_Click(object sender, EventArgs e)
        {
            rtb.SelectionAlignment = HorizontalAlignment.Right;
            CheckAndUncheckAlignmentButtons();
        }

        private void CheckAndUncheckAlignmentButtons()
        {
            HorizontalAlignment selectionAlignment = rtb.SelectionAlignment;
            toolStripRight.Checked = selectionAlignment == HorizontalAlignment.Right;
            toolStripLeft.Checked = selectionAlignment == HorizontalAlignment.Left;
            toolStripCenter.Checked = selectionAlignment == HorizontalAlignment.Center;
        }

        #endregion Alignment management

        #region Bullet management

        /// <summary>
        /// Handles the Click event of the toolStripBullet button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void toolStripBullet_Click(object sender, EventArgs e)
        {
            rtb.SelectionBullet = !rtb.SelectionBullet;
            CheckAndUncheckBulletButton();
        }

        private void CheckAndUncheckBulletButton()
        {
            toolStripBullet.Checked = rtb.SelectionBullet;
        }

        #endregion Bullet management


        #region Font and background color

        /// <summary>
        /// Handles the Click event of the toolStripForegroundColor button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void toolStripForegroundColor_Click(object sender, EventArgs e)
        {
            rtb.SelectionColor = toolStripForegroundColor.BackColor;
        }

        /// <summary>
        /// Handles the Click event of the toolStripBackgroundColor button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void toolStripBackgroundColor_Click(object sender, EventArgs e)
        {
            rtb.SelectionBackColor = toolStripBackgroundColor.BackColor;
        }

        /// <summary>
        /// Handles the Click event of the toolStripSelectForegroundColor button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void toolStripSelectForegroundColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = rtb.SelectionColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                rtb.SelectionColor = colorDialog.Color;
                PaintColorButtons();
            }
        }

        /// <summary>
        /// Handles the Click event of the toolStripSelectBackgroundColor button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void toolStripSelectBackgroundColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = rtb.SelectionBackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                rtb.SelectionBackColor = colorDialog.Color;
                PaintColorButtons();
            }
        }

        /// <summary>
        /// Sets the colors of the color buttons in the toolStrip to match the selction color.
        /// </summary>
        private void PaintColorButtons()
        {
            Color selectionColor = rtb.SelectionColor;
            Color selectionBackfroundColor = rtb.SelectionBackColor;
            toolStripBackgroundColor.BackColor = selectionBackfroundColor;
            toolStripBackgroundColor.ForeColor = selectionBackfroundColor;
            toolStripForegroundColor.BackColor = selectionColor;
            toolStripForegroundColor.ForeColor = selectionColor;
        }

        #endregion Font and background color




        #region CheckAndUnCheckAllButtons

        private void CheckAndUnCheckAllButtons()
        {
            CheckAndUncheckAlignmentButtons();
            CheckAndUncheckBulletButton();
            CheckAndUncheckStyleButtons();
        }

        #endregion CheckAndUnCheckAllButtons
    }
}
