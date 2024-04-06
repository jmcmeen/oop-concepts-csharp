namespace ChatClient
{
    partial class RegistrationForm
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
            btnSignin = new Button();
            passwordTextBox = new TextBox();
            userNameTextBox = new TextBox();
            serverIPTextBox = new TextBox();
            cancelButton = new Button();
            serverIpLabel = new Label();
            userNameLabel = new Label();
            passwordLabel = new Label();
            SuspendLayout();
            // 
            // btnSignin
            // 
            btnSignin.BackColor = SystemColors.Control;
            btnSignin.FlatStyle = FlatStyle.Flat;
            btnSignin.Font = new Font("Segoe UI", 9F);
            btnSignin.ForeColor = SystemColors.ControlText;
            btnSignin.Location = new Point(6, 118);
            btnSignin.Margin = new Padding(3, 4, 3, 4);
            btnSignin.Name = "btnSignin";
            btnSignin.Size = new Size(221, 29);
            btnSignin.TabIndex = 4;
            btnSignin.Text = "Register";
            btnSignin.UseVisualStyleBackColor = false;
            btnSignin.Click += btnSignin_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Segoe UI", 9F);
            passwordTextBox.Location = new Point(101, 83);
            passwordTextBox.Margin = new Padding(3, 4, 3, 4);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(267, 27);
            passwordTextBox.TabIndex = 3;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // userNameTextBox
            // 
            userNameTextBox.Font = new Font("Segoe UI", 9F);
            userNameTextBox.Location = new Point(101, 48);
            userNameTextBox.Margin = new Padding(3, 4, 3, 4);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(267, 27);
            userNameTextBox.TabIndex = 1;
            // 
            // serverIPTextBox
            // 
            serverIPTextBox.Font = new Font("Segoe UI", 9F);
            serverIPTextBox.Location = new Point(101, 13);
            serverIPTextBox.Margin = new Padding(3, 4, 3, 4);
            serverIPTextBox.Name = "serverIPTextBox";
            serverIPTextBox.Size = new Size(267, 27);
            serverIPTextBox.TabIndex = 0;
            // 
            // cancelButton
            // 
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Location = new Point(233, 118);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(135, 29);
            cancelButton.TabIndex = 12;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += button1_Click;
            // 
            // serverIpLabel
            // 
            serverIpLabel.AutoSize = true;
            serverIpLabel.Location = new Point(22, 13);
            serverIpLabel.Name = "serverIpLabel";
            serverIpLabel.Size = new Size(73, 20);
            serverIpLabel.TabIndex = 13;
            serverIpLabel.Text = "Server IP: ";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new Point(6, 48);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(89, 20);
            userNameLabel.TabIndex = 14;
            userNameLabel.Text = "User Name: ";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(18, 83);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(77, 20);
            passwordLabel.TabIndex = 15;
            passwordLabel.Text = "Password: ";
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 161);
            Controls.Add(passwordLabel);
            Controls.Add(userNameLabel);
            Controls.Add(serverIpLabel);
            Controls.Add(cancelButton);
            Controls.Add(btnSignin);
            Controls.Add(passwordTextBox);
            Controls.Add(userNameTextBox);
            Controls.Add(serverIPTextBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSignin;
        private TextBox passwordTextBox;
        private TextBox userNameTextBox;
        private TextBox serverIPTextBox;
        private Button cancelButton;
        private Label serverIpLabel;
        private Label userNameLabel;
        private Label passwordLabel;
    }
}