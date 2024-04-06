namespace ChatClient
{
    partial class LoginForm
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
            txtLoginPassword = new TextBox();
            txtLoginUsername = new TextBox();
            txtLoginIP = new TextBox();
            btnLogin = new Button();
            registerNewAccountButton = new Button();
            serverIpLabel = new Label();
            userNameLabel = new Label();
            passwordLabel = new Label();
            SuspendLayout();
            // 
            // txtLoginPassword
            // 
            txtLoginPassword.Font = new Font("Segoe UI", 9F);
            txtLoginPassword.Location = new Point(104, 83);
            txtLoginPassword.Margin = new Padding(3, 4, 3, 4);
            txtLoginPassword.Name = "txtLoginPassword";
            txtLoginPassword.Size = new Size(262, 27);
            txtLoginPassword.TabIndex = 2;
            txtLoginPassword.UseSystemPasswordChar = true;
            // 
            // txtLoginUsername
            // 
            txtLoginUsername.Font = new Font("Segoe UI", 9F);
            txtLoginUsername.Location = new Point(104, 48);
            txtLoginUsername.Margin = new Padding(3, 4, 3, 4);
            txtLoginUsername.Name = "txtLoginUsername";
            txtLoginUsername.Size = new Size(262, 27);
            txtLoginUsername.TabIndex = 1;
            // 
            // txtLoginIP
            // 
            txtLoginIP.Font = new Font("Segoe UI", 9F);
            txtLoginIP.Location = new Point(104, 13);
            txtLoginIP.Margin = new Padding(3, 4, 3, 4);
            txtLoginIP.Name = "txtLoginIP";
            txtLoginIP.Size = new Size(262, 27);
            txtLoginIP.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.Control;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 9F);
            btnLogin.ForeColor = SystemColors.ControlText;
            btnLogin.Location = new Point(9, 118);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(221, 29);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // registerNewAccountButton
            // 
            registerNewAccountButton.FlatStyle = FlatStyle.Flat;
            registerNewAccountButton.Location = new Point(236, 117);
            registerNewAccountButton.Name = "registerNewAccountButton";
            registerNewAccountButton.Size = new Size(130, 29);
            registerNewAccountButton.TabIndex = 32;
            registerNewAccountButton.Text = "Create Account";
            registerNewAccountButton.UseVisualStyleBackColor = true;
            registerNewAccountButton.Click += registerNewAccountButton_Click;
            // 
            // serverIpLabel
            // 
            serverIpLabel.AutoSize = true;
            serverIpLabel.Location = new Point(25, 13);
            serverIpLabel.Name = "serverIpLabel";
            serverIpLabel.Size = new Size(73, 20);
            serverIpLabel.TabIndex = 33;
            serverIpLabel.Text = "Server IP: ";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new Point(9, 48);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(89, 20);
            userNameLabel.TabIndex = 34;
            userNameLabel.Text = "User Name: ";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(21, 83);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(77, 20);
            passwordLabel.TabIndex = 35;
            passwordLabel.Text = "Password: ";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 161);
            Controls.Add(passwordLabel);
            Controls.Add(userNameLabel);
            Controls.Add(serverIpLabel);
            Controls.Add(registerNewAccountButton);
            Controls.Add(btnLogin);
            Controls.Add(txtLoginPassword);
            Controls.Add(txtLoginUsername);
            Controls.Add(txtLoginIP);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtLoginPassword;
        private TextBox txtLoginUsername;
        private TextBox txtLoginIP;
        private Button btnLogin;
        private Button registerNewAccountButton;
        private Label serverIpLabel;
        private Label userNameLabel;
        private Label passwordLabel;
    }
}