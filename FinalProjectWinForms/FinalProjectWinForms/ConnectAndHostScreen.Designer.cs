namespace FinalProjectWinForms
{
    partial class ConnectAndHostScreen
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.connectPortLabel = new System.Windows.Forms.Label();
            this.connectPortTextBox = new System.Windows.Forms.TextBox();
            this.connectHostIpLabel = new System.Windows.Forms.Label();
            this.connectNameLabel = new System.Windows.Forms.Label();
            this.connectNameTextBox = new System.Windows.Forms.TextBox();
            this.connectIpAddress = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hostPortLabel = new System.Windows.Forms.Label();
            this.hostPortTextBox = new System.Windows.Forms.TextBox();
            this.hostNameLabel = new System.Windows.Forms.Label();
            this.hostNameTextBox = new System.Windows.Forms.TextBox();
            this.hostButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.newRadioButton = new System.Windows.Forms.RadioButton();
            this.openRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.connectPortLabel);
            this.groupBox2.Controls.Add(this.connectPortTextBox);
            this.groupBox2.Controls.Add(this.connectHostIpLabel);
            this.groupBox2.Controls.Add(this.connectNameLabel);
            this.groupBox2.Controls.Add(this.connectNameTextBox);
            this.groupBox2.Controls.Add(this.connectIpAddress);
            this.groupBox2.Controls.Add(this.connectButton);
            this.groupBox2.Location = new System.Drawing.Point(271, 32);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(242, 175);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connect";
            // 
            // connectPortLabel
            // 
            this.connectPortLabel.AutoSize = true;
            this.connectPortLabel.Location = new System.Drawing.Point(37, 96);
            this.connectPortLabel.Name = "connectPortLabel";
            this.connectPortLabel.Size = new System.Drawing.Size(26, 13);
            this.connectPortLabel.TabIndex = 10;
            this.connectPortLabel.Text = "Port";
            // 
            // connectPortTextBox
            // 
            this.connectPortTextBox.Location = new System.Drawing.Point(98, 93);
            this.connectPortTextBox.Name = "connectPortTextBox";
            this.connectPortTextBox.Size = new System.Drawing.Size(122, 20);
            this.connectPortTextBox.TabIndex = 9;
            // 
            // connectHostIpLabel
            // 
            this.connectHostIpLabel.AutoSize = true;
            this.connectHostIpLabel.Location = new System.Drawing.Point(10, 70);
            this.connectHostIpLabel.Name = "connectHostIpLabel";
            this.connectHostIpLabel.Size = new System.Drawing.Size(83, 13);
            this.connectHostIpLabel.TabIndex = 8;
            this.connectHostIpLabel.Text = "Host IP Address";
            // 
            // connectNameLabel
            // 
            this.connectNameLabel.AutoSize = true;
            this.connectNameLabel.Location = new System.Drawing.Point(32, 45);
            this.connectNameLabel.Name = "connectNameLabel";
            this.connectNameLabel.Size = new System.Drawing.Size(35, 13);
            this.connectNameLabel.TabIndex = 7;
            this.connectNameLabel.Text = "Name";
            // 
            // connectNameTextBox
            // 
            this.connectNameTextBox.Location = new System.Drawing.Point(98, 43);
            this.connectNameTextBox.Name = "connectNameTextBox";
            this.connectNameTextBox.Size = new System.Drawing.Size(122, 20);
            this.connectNameTextBox.TabIndex = 6;
            // 
            // connectIpAddress
            // 
            this.connectIpAddress.Location = new System.Drawing.Point(98, 68);
            this.connectIpAddress.Margin = new System.Windows.Forms.Padding(2);
            this.connectIpAddress.Name = "connectIpAddress";
            this.connectIpAddress.Size = new System.Drawing.Size(122, 20);
            this.connectIpAddress.TabIndex = 5;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(82, 141);
            this.connectButton.Margin = new System.Windows.Forms.Padding(2);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 19);
            this.connectButton.TabIndex = 4;
            this.connectButton.Text = "CONNECT";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hostPortLabel);
            this.groupBox1.Controls.Add(this.hostPortTextBox);
            this.groupBox1.Controls.Add(this.hostNameLabel);
            this.groupBox1.Controls.Add(this.hostNameTextBox);
            this.groupBox1.Controls.Add(this.hostButton);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(18, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(242, 175);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Host";
            // 
            // hostPortLabel
            // 
            this.hostPortLabel.AutoSize = true;
            this.hostPortLabel.Location = new System.Drawing.Point(55, 116);
            this.hostPortLabel.Name = "hostPortLabel";
            this.hostPortLabel.Size = new System.Drawing.Size(26, 13);
            this.hostPortLabel.TabIndex = 8;
            this.hostPortLabel.Text = "Port";
            // 
            // hostPortTextBox
            // 
            this.hostPortTextBox.Location = new System.Drawing.Point(90, 113);
            this.hostPortTextBox.Name = "hostPortTextBox";
            this.hostPortTextBox.Size = new System.Drawing.Size(100, 20);
            this.hostPortTextBox.TabIndex = 7;
            // 
            // hostNameLabel
            // 
            this.hostNameLabel.AutoSize = true;
            this.hostNameLabel.Location = new System.Drawing.Point(49, 90);
            this.hostNameLabel.Name = "hostNameLabel";
            this.hostNameLabel.Size = new System.Drawing.Size(35, 13);
            this.hostNameLabel.TabIndex = 6;
            this.hostNameLabel.Text = "Name";
            // 
            // hostNameTextBox
            // 
            this.hostNameTextBox.Location = new System.Drawing.Point(90, 87);
            this.hostNameTextBox.Name = "hostNameTextBox";
            this.hostNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.hostNameTextBox.TabIndex = 5;
            // 
            // hostButton
            // 
            this.hostButton.Location = new System.Drawing.Point(90, 140);
            this.hostButton.Margin = new System.Windows.Forms.Padding(2);
            this.hostButton.Name = "hostButton";
            this.hostButton.Size = new System.Drawing.Size(56, 19);
            this.hostButton.TabIndex = 4;
            this.hostButton.Text = "HOST";
            this.hostButton.UseVisualStyleBackColor = true;
            this.hostButton.Click += new System.EventHandler(this.hostButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.newRadioButton);
            this.panel1.Controls.Add(this.openRadioButton);
            this.panel1.Location = new System.Drawing.Point(31, 17);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 60);
            this.panel1.TabIndex = 1;
            // 
            // newRadioButton
            // 
            this.newRadioButton.AutoSize = true;
            this.newRadioButton.Location = new System.Drawing.Point(40, 11);
            this.newRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.newRadioButton.Name = "newRadioButton";
            this.newRadioButton.Size = new System.Drawing.Size(99, 17);
            this.newRadioButton.TabIndex = 0;
            this.newRadioButton.TabStop = true;
            this.newRadioButton.Text = "New Document";
            this.newRadioButton.UseVisualStyleBackColor = true;
            // 
            // openRadioButton
            // 
            this.openRadioButton.AutoSize = true;
            this.openRadioButton.Location = new System.Drawing.Point(40, 33);
            this.openRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.openRadioButton.Name = "openRadioButton";
            this.openRadioButton.Size = new System.Drawing.Size(90, 17);
            this.openRadioButton.TabIndex = 1;
            this.openRadioButton.TabStop = true;
            this.openRadioButton.Text = "Open Existing";
            this.openRadioButton.UseVisualStyleBackColor = true;
            // 
            // ConnectAndHostScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 236);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConnectAndHostScreen";
            this.Text = "Opening Screen";
            this.Load += new System.EventHandler(this.ConnectAndHostScreen_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label connectNameLabel;
        private System.Windows.Forms.TextBox connectNameTextBox;
        private System.Windows.Forms.TextBox connectIpAddress;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label hostNameLabel;
        private System.Windows.Forms.TextBox hostNameTextBox;
        private System.Windows.Forms.Button hostButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton newRadioButton;
        private System.Windows.Forms.RadioButton openRadioButton;
        private System.Windows.Forms.Label connectHostIpLabel;
        private System.Windows.Forms.Label connectPortLabel;
        private System.Windows.Forms.TextBox connectPortTextBox;
        private System.Windows.Forms.Label hostPortLabel;
        private System.Windows.Forms.TextBox hostPortTextBox;
    }
}