namespace BindingSource
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            lootListBindingSource = new System.Windows.Forms.BindingSource(components);
            addLootButton = new Button();
            lootListBox = new ListBox();
            nameLabel = new Label();
            priceLabel = new Label();
            descriptionLabel = new Label();
            nameTextBox = new TextBox();
            priceTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            looterV10ToolStripMenuItem = new ToolStripMenuItem();
            mainPanel = new Panel();
            removeLootButton = new Button();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)lootListBindingSource).BeginInit();
            menuStrip.SuspendLayout();
            mainPanel.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // addLootButton
            // 
            addLootButton.Location = new Point(12, 193);
            addLootButton.Name = "addLootButton";
            addLootButton.Size = new Size(225, 29);
            addLootButton.TabIndex = 0;
            addLootButton.Text = "Add Loot";
            addLootButton.UseVisualStyleBackColor = true;
            addLootButton.Click += addLootButton_Click;
            // 
            // lootListBox
            // 
            lootListBox.FormattingEnabled = true;
            lootListBox.Location = new Point(243, 3);
            lootListBox.Name = "lootListBox";
            lootListBox.Size = new Size(260, 184);
            lootListBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(10, 6);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(52, 20);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(10, 39);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(41, 20);
            priceLabel.TabIndex = 3;
            priceLabel.Text = "Price";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(10, 72);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(85, 20);
            descriptionLabel.TabIndex = 4;
            descriptionLabel.Text = "Description";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(66, 3);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(171, 27);
            nameTextBox.TabIndex = 5;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(66, 36);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(171, 27);
            priceTextBox.TabIndex = 6;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(12, 95);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.ScrollBars = ScrollBars.Vertical;
            descriptionTextBox.Size = new Size(225, 92);
            descriptionTextBox.TabIndex = 7;
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(525, 28);
            menuStrip.TabIndex = 8;
            menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, closeToolStripMenuItem, toolStripSeparator1, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator2, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(143, 26);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(143, 26);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(143, 26);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(140, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(143, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(143, 26);
            saveAsToolStripMenuItem.Text = "Save As";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(140, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(143, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { looterV10ToolStripMenuItem });
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(64, 24);
            aboutToolStripMenuItem.Text = "About";
            // 
            // looterV10ToolStripMenuItem
            // 
            looterV10ToolStripMenuItem.Name = "looterV10ToolStripMenuItem";
            looterV10ToolStripMenuItem.Size = new Size(165, 26);
            looterV10ToolStripMenuItem.Text = "Looter v1.0";
            looterV10ToolStripMenuItem.Click += looterV10ToolStripMenuItem_Click;
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(removeLootButton);
            mainPanel.Controls.Add(nameTextBox);
            mainPanel.Controls.Add(addLootButton);
            mainPanel.Controls.Add(descriptionTextBox);
            mainPanel.Controls.Add(lootListBox);
            mainPanel.Controls.Add(priceTextBox);
            mainPanel.Controls.Add(nameLabel);
            mainPanel.Controls.Add(priceLabel);
            mainPanel.Controls.Add(descriptionLabel);
            mainPanel.Location = new Point(0, 31);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(520, 235);
            mainPanel.TabIndex = 9;
            // 
            // removeLootButton
            // 
            removeLootButton.Location = new Point(243, 193);
            removeLootButton.Name = "removeLootButton";
            removeLootButton.Size = new Size(260, 29);
            removeLootButton.TabIndex = 8;
            removeLootButton.Text = "Remove Loot";
            removeLootButton.UseVisualStyleBackColor = true;
            removeLootButton.Click += removeLootButton_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 272);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(525, 22);
            statusStrip.TabIndex = 10;
            statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(0, 16);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 294);
            Controls.Add(statusStrip);
            Controls.Add(mainPanel);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "MainForm";
            Text = "Looter";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)lootListBindingSource).EndInit();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.BindingSource lootListBindingSource;
        private Button addLootButton;
        private ListBox lootListBox;
        private Label nameLabel;
        private Label priceLabel;
        private Label descriptionLabel;
        private TextBox nameTextBox;
        private TextBox priceTextBox;
        private TextBox descriptionTextBox;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem looterV10ToolStripMenuItem;
        private Panel mainPanel;
        private Button removeLootButton;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripStatusLabel;
        private ToolStripMenuItem closeToolStripMenuItem;
    }
}
