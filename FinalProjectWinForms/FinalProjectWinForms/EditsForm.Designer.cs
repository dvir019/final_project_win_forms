namespace FinalProjectWinForms
{
    partial class EditsForm
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
            this.editsTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // editsTextBox
            // 
            this.editsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editsTextBox.Location = new System.Drawing.Point(0, 0);
            this.editsTextBox.Name = "editsTextBox";
            this.editsTextBox.ReadOnly = true;
            this.editsTextBox.Size = new System.Drawing.Size(357, 266);
            this.editsTextBox.TabIndex = 0;
            this.editsTextBox.Text = "";
            // 
            // EditsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 266);
            this.Controls.Add(this.editsTextBox);
            this.Name = "EditsForm";
            this.Text = "Edits";
            this.Load += new System.EventHandler(this.EditsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox editsTextBox;
    }
}