namespace ChatServer
{
    partial class ServerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ipLabel = new Label();
            txtIP = new TextBox();
            label3 = new Label();
            txtPort = new TextBox();
            btnStart = new Button();
            rtbDialog = new RichTextBox();
            btnStop = new Button();
            copyButton = new Button();
            SuspendLayout();
            // 
            // ipLabel
            // 
            ipLabel.AutoSize = true;
            ipLabel.Font = new Font("Segoe UI", 9F);
            ipLabel.Location = new Point(12, 7);
            ipLabel.Name = "ipLabel";
            ipLabel.Size = new Size(78, 20);
            ipLabel.TabIndex = 1;
            ipLabel.Text = "IP Address";
            // 
            // txtIP
            // 
            txtIP.Font = new Font("Segoe UI", 9F);
            txtIP.Location = new Point(96, 7);
            txtIP.Name = "txtIP";
            txtIP.ReadOnly = true;
            txtIP.Size = new Size(160, 27);
            txtIP.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(55, 39);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 1;
            label3.Text = "Port";
            // 
            // txtPort
            // 
            txtPort.Font = new Font("Segoe UI", 9F);
            txtPort.Location = new Point(96, 39);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(91, 27);
            txtPort.TabIndex = 2;
            // 
            // btnStart
            // 
            btnStart.BackColor = SystemColors.ButtonFace;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Segoe UI", 9F);
            btnStart.ForeColor = SystemColors.ControlText;
            btnStart.Location = new Point(12, 71);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(309, 32);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start Server";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // rtbDialog
            // 
            rtbDialog.Enabled = false;
            rtbDialog.Location = new Point(12, 109);
            rtbDialog.Name = "rtbDialog";
            rtbDialog.Size = new Size(306, 374);
            rtbDialog.TabIndex = 4;
            rtbDialog.Text = "";
            // 
            // btnStop
            // 
            btnStop.BackColor = SystemColors.ButtonFace;
            btnStop.FlatStyle = FlatStyle.Flat;
            btnStop.Font = new Font("Segoe UI", 9F);
            btnStop.ForeColor = SystemColors.ControlText;
            btnStop.Location = new Point(12, 489);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(306, 32);
            btnStop.TabIndex = 3;
            btnStop.Text = "Stop Server";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click;
            // 
            // copyButton
            // 
            copyButton.FlatStyle = FlatStyle.Flat;
            copyButton.Location = new Point(262, 7);
            copyButton.Name = "copyButton";
            copyButton.Size = new Size(56, 29);
            copyButton.TabIndex = 5;
            copyButton.Text = "Copy";
            copyButton.UseVisualStyleBackColor = true;
            copyButton.Click += copyButton_Click;
            // 
            // ServerForm
            // 
            BackColor = SystemColors.Control;
            ClientSize = new Size(330, 533);
            Controls.Add(copyButton);
            Controls.Add(rtbDialog);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(txtPort);
            Controls.Add(label3);
            Controls.Add(txtIP);
            Controls.Add(ipLabel);
            Name = "ServerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chat Server";
            Load += Server_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label ipLabel;
        private TextBox txtIP;
        private Label label3;
        private TextBox txtPort;
        private Button btnStart;
        private RichTextBox rtbDialog;
        private Button btnStop;
        private Button copyButton;
    }
}