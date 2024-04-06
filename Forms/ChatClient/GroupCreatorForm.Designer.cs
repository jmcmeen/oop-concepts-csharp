namespace ChatClient
{
    partial class GroupCreatorForm
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
            txtGroupName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtMembers = new TextBox();
            btnCreate = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // txtGroupName
            // 
            txtGroupName.Font = new Font("Times New Roman", 9.75F);
            txtGroupName.Location = new Point(115, 13);
            txtGroupName.Margin = new Padding(3, 4, 3, 4);
            txtGroupName.Name = "txtGroupName";
            txtGroupName.Size = new Size(194, 26);
            txtGroupName.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(8, 13);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 4;
            label2.Text = "Group Name: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(31, 47);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 5;
            label3.Text = "Members: ";
            // 
            // txtMembers
            // 
            txtMembers.Font = new Font("Times New Roman", 9.75F);
            txtMembers.Location = new Point(115, 47);
            txtMembers.Margin = new Padding(3, 4, 3, 4);
            txtMembers.Name = "txtMembers";
            txtMembers.Size = new Size(194, 26);
            txtMembers.TabIndex = 1;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = SystemColors.Control;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI", 9F);
            btnCreate.ForeColor = SystemColors.ControlText;
            btnCreate.Location = new Point(12, 80);
            btnCreate.Margin = new Padding(3, 4, 3, 4);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(197, 29);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Create Group";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // cancelButton
            // 
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Location = new Point(215, 80);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(94, 29);
            cancelButton.TabIndex = 6;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // GroupCreatorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 122);
            Controls.Add(cancelButton);
            Controls.Add(btnCreate);
            Controls.Add(txtMembers);
            Controls.Add(label3);
            Controls.Add(txtGroupName);
            Controls.Add(label2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GroupCreatorForm";
            Text = "Create a New Group";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtGroupName;
        private Label label2;
        private Label label3;
        private TextBox txtMembers;
        private Button btnCreate;
        private Button cancelButton;
    }
}