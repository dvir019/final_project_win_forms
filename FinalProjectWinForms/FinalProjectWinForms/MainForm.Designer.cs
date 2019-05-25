namespace FinalProjectWinForms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSave = new System.Windows.Forms.ToolStripButton();
            this.tsFileSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripCut = new System.Windows.Forms.ToolStripButton();
            this.toolStripCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripUndo = new System.Windows.Forms.ToolStripButton();
            this.toolStripRedo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBold = new System.Windows.Forms.ToolStripButton();
            this.toolStripItalic = new System.Windows.Forms.ToolStripButton();
            this.toolStripUnderline = new System.Windows.Forms.ToolStripButton();
            this.toolStripStrikeout = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLeft = new System.Windows.Forms.ToolStripButton();
            this.toolStripCenter = new System.Windows.Forms.ToolStripButton();
            this.toolStripRight = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripForegroundColor = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsSelectFontColor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripBackgroundColor = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsSelectBackgroundColor = new System.Windows.Forms.ToolStripMenuItem();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripNew,
            this.toolStripOpen,
            this.toolStripSave,
            this.tsFileSeparator,
            this.toolStripCut,
            this.toolStripCopy,
            this.toolStripPaste,
            this.toolStripSeparator4,
            this.toolStripUndo,
            this.toolStripRedo,
            this.toolStripSeparator1,
            this.toolStripBold,
            this.toolStripItalic,
            this.toolStripUnderline,
            this.toolStripStrikeout,
            this.toolStripSeparator2,
            this.toolStripLeft,
            this.toolStripCenter,
            this.toolStripRight,
            this.toolStripSeparator3,
            this.toolStripForegroundColor,
            this.toolStripBackgroundColor});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripNew
            // 
            this.toolStripNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripNew.Image = global::FinalProjectWinForms.Properties.Resources.newdocument;
            this.toolStripNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripNew.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripNew.Name = "toolStripNew";
            this.toolStripNew.Size = new System.Drawing.Size(24, 24);
            this.toolStripNew.Text = "New";
            // 
            // toolStripOpen
            // 
            this.toolStripOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripOpen.Image = global::FinalProjectWinForms.Properties.Resources.open;
            this.toolStripOpen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripOpen.ImageTransparentColor = System.Drawing.Color.Black;
            this.toolStripOpen.Name = "toolStripOpen";
            this.toolStripOpen.Size = new System.Drawing.Size(23, 24);
            this.toolStripOpen.Text = "Open";
            // 
            // toolStripSave
            // 
            this.toolStripSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSave.Image = global::FinalProjectWinForms.Properties.Resources.save;
            this.toolStripSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSave.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripSave.Name = "toolStripSave";
            this.toolStripSave.Size = new System.Drawing.Size(24, 24);
            this.toolStripSave.Text = "Save";
            // 
            // tsFileSeparator
            // 
            this.tsFileSeparator.Name = "tsFileSeparator";
            this.tsFileSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripCut
            // 
            this.toolStripCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripCut.Image = global::FinalProjectWinForms.Properties.Resources.cut;
            this.toolStripCut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripCut.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripCut.Name = "toolStripCut";
            this.toolStripCut.Size = new System.Drawing.Size(24, 24);
            this.toolStripCut.Text = "Cut";
            // 
            // toolStripCopy
            // 
            this.toolStripCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripCopy.Image = global::FinalProjectWinForms.Properties.Resources.copy;
            this.toolStripCopy.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripCopy.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripCopy.Name = "toolStripCopy";
            this.toolStripCopy.Size = new System.Drawing.Size(24, 24);
            this.toolStripCopy.Text = "Copy";
            // 
            // toolStripPaste
            // 
            this.toolStripPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPaste.Image = global::FinalProjectWinForms.Properties.Resources.paste;
            this.toolStripPaste.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripPaste.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripPaste.Name = "toolStripPaste";
            this.toolStripPaste.Size = new System.Drawing.Size(24, 24);
            this.toolStripPaste.Text = "Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripUndo
            // 
            this.toolStripUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripUndo.Image = global::FinalProjectWinForms.Properties.Resources.undo;
            this.toolStripUndo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripUndo.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripUndo.Name = "toolStripUndo";
            this.toolStripUndo.Size = new System.Drawing.Size(24, 24);
            this.toolStripUndo.Text = "Undo";
            // 
            // toolStripRedo
            // 
            this.toolStripRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripRedo.Image = global::FinalProjectWinForms.Properties.Resources.redo;
            this.toolStripRedo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripRedo.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripRedo.Name = "toolStripRedo";
            this.toolStripRedo.Size = new System.Drawing.Size(24, 24);
            this.toolStripRedo.Text = "Redo";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripBold
            // 
            this.toolStripBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBold.Image = global::FinalProjectWinForms.Properties.Resources.bold;
            this.toolStripBold.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBold.Name = "toolStripBold";
            this.toolStripBold.Size = new System.Drawing.Size(24, 24);
            this.toolStripBold.Text = "Bold";
            // 
            // toolStripItalic
            // 
            this.toolStripItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripItalic.Image = global::FinalProjectWinForms.Properties.Resources.italic;
            this.toolStripItalic.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripItalic.Name = "toolStripItalic";
            this.toolStripItalic.Size = new System.Drawing.Size(24, 24);
            this.toolStripItalic.Text = "Italic";
            // 
            // toolStripUnderline
            // 
            this.toolStripUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripUnderline.Image = global::FinalProjectWinForms.Properties.Resources.underline;
            this.toolStripUnderline.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripUnderline.Name = "toolStripUnderline";
            this.toolStripUnderline.Size = new System.Drawing.Size(24, 24);
            this.toolStripUnderline.Text = "Underline";
            // 
            // toolStripStrikeout
            // 
            this.toolStripStrikeout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripStrikeout.Image = global::FinalProjectWinForms.Properties.Resources.strikethrough;
            this.toolStripStrikeout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripStrikeout.Name = "toolStripStrikeout";
            this.toolStripStrikeout.Size = new System.Drawing.Size(24, 24);
            this.toolStripStrikeout.Text = "Strikeout";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLeft
            // 
            this.toolStripLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLeft.Image = global::FinalProjectWinForms.Properties.Resources.justifyleft;
            this.toolStripLeft.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripLeft.Name = "toolStripLeft";
            this.toolStripLeft.Size = new System.Drawing.Size(24, 24);
            this.toolStripLeft.Text = "Left";
            // 
            // toolStripCenter
            // 
            this.toolStripCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripCenter.Image = global::FinalProjectWinForms.Properties.Resources.justifycenter;
            this.toolStripCenter.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripCenter.Name = "toolStripCenter";
            this.toolStripCenter.Size = new System.Drawing.Size(24, 24);
            this.toolStripCenter.Text = "Center";
            // 
            // toolStripRight
            // 
            this.toolStripRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripRight.Image = global::FinalProjectWinForms.Properties.Resources.justifyright;
            this.toolStripRight.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripRight.Name = "toolStripRight";
            this.toolStripRight.Size = new System.Drawing.Size(24, 24);
            this.toolStripRight.Text = "Right";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripForegroundColor
            // 
            this.toolStripForegroundColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripForegroundColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSelectFontColor});
            this.toolStripForegroundColor.Image = global::FinalProjectWinForms.Properties.Resources.forecolor;
            this.toolStripForegroundColor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripForegroundColor.Name = "toolStripForegroundColor";
            this.toolStripForegroundColor.Size = new System.Drawing.Size(33, 24);
            this.toolStripForegroundColor.Text = "    ";
            this.toolStripForegroundColor.ToolTipText = "Font color  ";
            // 
            // tsSelectFontColor
            // 
            this.tsSelectFontColor.Name = "tsSelectFontColor";
            this.tsSelectFontColor.Size = new System.Drawing.Size(180, 22);
            this.tsSelectFontColor.Text = "Select color...";
            // 
            // toolStripBackgroundColor
            // 
            this.toolStripBackgroundColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBackgroundColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSelectBackgroundColor});
            this.toolStripBackgroundColor.Image = global::FinalProjectWinForms.Properties.Resources.backcolor;
            this.toolStripBackgroundColor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBackgroundColor.Name = "toolStripBackgroundColor";
            this.toolStripBackgroundColor.Size = new System.Drawing.Size(33, 24);
            this.toolStripBackgroundColor.Text = "    ";
            this.toolStripBackgroundColor.ToolTipText = "Background color";
            // 
            // tsSelectBackgroundColor
            // 
            this.tsSelectBackgroundColor.Name = "tsSelectBackgroundColor";
            this.tsSelectBackgroundColor.Size = new System.Drawing.Size(180, 22);
            this.tsSelectBackgroundColor.Text = "Select color...";
            // 
            // rtb
            // 
            this.rtb.Location = new System.Drawing.Point(48, 54);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(728, 384);
            this.rtb.TabIndex = 2;
            this.rtb.Text = "";
            this.rtb.WordWrap = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtb);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripNew;
        private System.Windows.Forms.ToolStripButton toolStripOpen;
        private System.Windows.Forms.ToolStripButton toolStripSave;
        private System.Windows.Forms.ToolStripSeparator tsFileSeparator;
        private System.Windows.Forms.ToolStripButton toolStripCut;
        private System.Windows.Forms.ToolStripButton toolStripCopy;
        private System.Windows.Forms.ToolStripButton toolStripPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripUndo;
        private System.Windows.Forms.ToolStripButton toolStripRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripBold;
        private System.Windows.Forms.ToolStripButton toolStripItalic;
        private System.Windows.Forms.ToolStripButton toolStripUnderline;
        private System.Windows.Forms.ToolStripButton toolStripStrikeout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripLeft;
        private System.Windows.Forms.ToolStripButton toolStripCenter;
        private System.Windows.Forms.ToolStripButton toolStripRight;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton toolStripForegroundColor;
        private System.Windows.Forms.ToolStripMenuItem tsSelectFontColor;
        private System.Windows.Forms.ToolStripDropDownButton toolStripBackgroundColor;
        private System.Windows.Forms.ToolStripMenuItem tsSelectBackgroundColor;
        private System.Windows.Forms.RichTextBox rtb;
    }
}

