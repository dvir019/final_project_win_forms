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
            this.tsNew = new System.Windows.Forms.ToolStripButton();
            this.tsOpen = new System.Windows.Forms.ToolStripButton();
            this.tsSave = new System.Windows.Forms.ToolStripButton();
            this.tsFileSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsCut = new System.Windows.Forms.ToolStripButton();
            this.tsCopy = new System.Windows.Forms.ToolStripButton();
            this.tsPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsUndo = new System.Windows.Forms.ToolStripButton();
            this.tsRedo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBold = new System.Windows.Forms.ToolStripButton();
            this.tsItalic = new System.Windows.Forms.ToolStripButton();
            this.tsUnderline = new System.Windows.Forms.ToolStripButton();
            this.tsStrikeout = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsLeft = new System.Windows.Forms.ToolStripButton();
            this.tsCenter = new System.Windows.Forms.ToolStripButton();
            this.tsRight = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsFontColor = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsSelectFontColor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBackgroundColor = new System.Windows.Forms.ToolStripDropDownButton();
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
            this.tsNew,
            this.tsOpen,
            this.tsSave,
            this.tsFileSeparator,
            this.tsCut,
            this.tsCopy,
            this.tsPaste,
            this.toolStripSeparator4,
            this.tsUndo,
            this.tsRedo,
            this.toolStripSeparator1,
            this.tsBold,
            this.tsItalic,
            this.tsUnderline,
            this.tsStrikeout,
            this.toolStripSeparator2,
            this.tsLeft,
            this.tsCenter,
            this.tsRight,
            this.toolStripSeparator3,
            this.tsFontColor,
            this.tsBackgroundColor});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsNew
            // 
            this.tsNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsNew.Image = global::FinalProjectWinForms.Properties.Resources.newdocument;
            this.tsNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsNew.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tsNew.Name = "tsNew";
            this.tsNew.Size = new System.Drawing.Size(24, 24);
            this.tsNew.Text = "New";
            // 
            // tsOpen
            // 
            this.tsOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsOpen.Image = global::FinalProjectWinForms.Properties.Resources.open;
            this.tsOpen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsOpen.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsOpen.Name = "tsOpen";
            this.tsOpen.Size = new System.Drawing.Size(23, 24);
            this.tsOpen.Text = "Open";
            // 
            // tsSave
            // 
            this.tsSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsSave.Image = global::FinalProjectWinForms.Properties.Resources.save;
            this.tsSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsSave.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tsSave.Name = "tsSave";
            this.tsSave.Size = new System.Drawing.Size(24, 24);
            this.tsSave.Text = "Save";
            // 
            // tsFileSeparator
            // 
            this.tsFileSeparator.Name = "tsFileSeparator";
            this.tsFileSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // tsCut
            // 
            this.tsCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsCut.Image = global::FinalProjectWinForms.Properties.Resources.cut;
            this.tsCut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsCut.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tsCut.Name = "tsCut";
            this.tsCut.Size = new System.Drawing.Size(24, 24);
            this.tsCut.Text = "Cut";
            // 
            // tsCopy
            // 
            this.tsCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsCopy.Image = global::FinalProjectWinForms.Properties.Resources.copy;
            this.tsCopy.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsCopy.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tsCopy.Name = "tsCopy";
            this.tsCopy.Size = new System.Drawing.Size(24, 24);
            this.tsCopy.Text = "Copy";
            // 
            // tsPaste
            // 
            this.tsPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsPaste.Image = global::FinalProjectWinForms.Properties.Resources.paste;
            this.tsPaste.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsPaste.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tsPaste.Name = "tsPaste";
            this.tsPaste.Size = new System.Drawing.Size(24, 24);
            this.tsPaste.Text = "Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // tsUndo
            // 
            this.tsUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsUndo.Image = global::FinalProjectWinForms.Properties.Resources.undo;
            this.tsUndo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsUndo.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tsUndo.Name = "tsUndo";
            this.tsUndo.Size = new System.Drawing.Size(24, 24);
            this.tsUndo.Text = "Undo";
            // 
            // tsRedo
            // 
            this.tsRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsRedo.Image = global::FinalProjectWinForms.Properties.Resources.redo;
            this.tsRedo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsRedo.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tsRedo.Name = "tsRedo";
            this.tsRedo.Size = new System.Drawing.Size(24, 24);
            this.tsRedo.Text = "Redo";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tsBold
            // 
            this.tsBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBold.Image = global::FinalProjectWinForms.Properties.Resources.bold;
            this.tsBold.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBold.Name = "tsBold";
            this.tsBold.Size = new System.Drawing.Size(24, 24);
            this.tsBold.Text = "Bold";
            // 
            // tsItalic
            // 
            this.tsItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsItalic.Image = global::FinalProjectWinForms.Properties.Resources.italic;
            this.tsItalic.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsItalic.Name = "tsItalic";
            this.tsItalic.Size = new System.Drawing.Size(24, 24);
            this.tsItalic.Text = "Italic";
            // 
            // tsUnderline
            // 
            this.tsUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsUnderline.Image = global::FinalProjectWinForms.Properties.Resources.underline;
            this.tsUnderline.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsUnderline.Name = "tsUnderline";
            this.tsUnderline.Size = new System.Drawing.Size(24, 24);
            this.tsUnderline.Text = "Underline";
            // 
            // tsStrikeout
            // 
            this.tsStrikeout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsStrikeout.Image = global::FinalProjectWinForms.Properties.Resources.strikethrough;
            this.tsStrikeout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsStrikeout.Name = "tsStrikeout";
            this.tsStrikeout.Size = new System.Drawing.Size(24, 24);
            this.tsStrikeout.Text = "Strikeout";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tsLeft
            // 
            this.tsLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsLeft.Image = global::FinalProjectWinForms.Properties.Resources.justifyleft;
            this.tsLeft.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsLeft.Name = "tsLeft";
            this.tsLeft.Size = new System.Drawing.Size(24, 24);
            this.tsLeft.Text = "Left";
            // 
            // tsCenter
            // 
            this.tsCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsCenter.Image = global::FinalProjectWinForms.Properties.Resources.justifycenter;
            this.tsCenter.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsCenter.Name = "tsCenter";
            this.tsCenter.Size = new System.Drawing.Size(24, 24);
            this.tsCenter.Text = "Center";
            // 
            // tsRight
            // 
            this.tsRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsRight.Image = global::FinalProjectWinForms.Properties.Resources.justifyright;
            this.tsRight.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsRight.Name = "tsRight";
            this.tsRight.Size = new System.Drawing.Size(24, 24);
            this.tsRight.Text = "Right";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // tsFontColor
            // 
            this.tsFontColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsFontColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSelectFontColor});
            this.tsFontColor.Image = global::FinalProjectWinForms.Properties.Resources.forecolor;
            this.tsFontColor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsFontColor.Name = "tsFontColor";
            this.tsFontColor.Size = new System.Drawing.Size(33, 24);
            this.tsFontColor.Text = "    ";
            this.tsFontColor.ToolTipText = "Font color  ";
            // 
            // tsSelectFontColor
            // 
            this.tsSelectFontColor.Name = "tsSelectFontColor";
            this.tsSelectFontColor.Size = new System.Drawing.Size(180, 22);
            this.tsSelectFontColor.Text = "Select color...";
            // 
            // tsBackgroundColor
            // 
            this.tsBackgroundColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBackgroundColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSelectBackgroundColor});
            this.tsBackgroundColor.Image = global::FinalProjectWinForms.Properties.Resources.backcolor;
            this.tsBackgroundColor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBackgroundColor.Name = "tsBackgroundColor";
            this.tsBackgroundColor.Size = new System.Drawing.Size(33, 24);
            this.tsBackgroundColor.Text = "    ";
            this.tsBackgroundColor.ToolTipText = "Background color";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtb);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
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
        private System.Windows.Forms.ToolStripButton tsNew;
        private System.Windows.Forms.ToolStripButton tsOpen;
        private System.Windows.Forms.ToolStripButton tsSave;
        private System.Windows.Forms.ToolStripSeparator tsFileSeparator;
        private System.Windows.Forms.ToolStripButton tsCut;
        private System.Windows.Forms.ToolStripButton tsCopy;
        private System.Windows.Forms.ToolStripButton tsPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsUndo;
        private System.Windows.Forms.ToolStripButton tsRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsBold;
        private System.Windows.Forms.ToolStripButton tsItalic;
        private System.Windows.Forms.ToolStripButton tsUnderline;
        private System.Windows.Forms.ToolStripButton tsStrikeout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsLeft;
        private System.Windows.Forms.ToolStripButton tsCenter;
        private System.Windows.Forms.ToolStripButton tsRight;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton tsFontColor;
        private System.Windows.Forms.ToolStripMenuItem tsSelectFontColor;
        private System.Windows.Forms.ToolStripDropDownButton tsBackgroundColor;
        private System.Windows.Forms.ToolStripMenuItem tsSelectBackgroundColor;
        private System.Windows.Forms.RichTextBox rtb;
    }
}

