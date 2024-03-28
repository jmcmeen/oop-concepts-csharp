namespace XX_FileDialog
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
            openFileDialog = new OpenFileDialog();
            filePathTextBox = new TextBox();
            selectFileButton = new Button();
            outputTextBox = new TextBox();
            outputGroup = new GroupBox();
            noteLabel = new Label();
            outputGroup.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // filePathTextBox
            // 
            filePathTextBox.Location = new Point(18, 20);
            filePathTextBox.Margin = new Padding(4, 5, 4, 5);
            filePathTextBox.Name = "filePathTextBox";
            filePathTextBox.ReadOnly = true;
            filePathTextBox.Size = new Size(645, 31);
            filePathTextBox.TabIndex = 0;
            // 
            // selectFileButton
            // 
            selectFileButton.Location = new Point(672, 20);
            selectFileButton.Margin = new Padding(4, 5, 4, 5);
            selectFileButton.Name = "selectFileButton";
            selectFileButton.Size = new Size(108, 39);
            selectFileButton.TabIndex = 1;
            selectFileButton.Text = "Select File";
            selectFileButton.UseVisualStyleBackColor = true;
            selectFileButton.Click += selectFileButton_Click;
            // 
            // outputTextBox
            // 
            outputTextBox.Location = new Point(9, 36);
            outputTextBox.Margin = new Padding(4, 5, 4, 5);
            outputTextBox.Multiline = true;
            outputTextBox.Name = "outputTextBox";
            outputTextBox.ReadOnly = true;
            outputTextBox.ScrollBars = ScrollBars.Vertical;
            outputTextBox.Size = new Size(743, 410);
            outputTextBox.TabIndex = 2;
            outputTextBox.WordWrap = false;
            // 
            // outputGroup
            // 
            outputGroup.Controls.Add(outputTextBox);
            outputGroup.Location = new Point(19, 90);
            outputGroup.Margin = new Padding(4, 5, 4, 5);
            outputGroup.Name = "outputGroup";
            outputGroup.Padding = new Padding(4, 5, 4, 5);
            outputGroup.Size = new Size(761, 460);
            outputGroup.TabIndex = 3;
            outputGroup.TabStop = false;
            outputGroup.Text = "Hex";
            // 
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.Location = new Point(19, 555);
            noteLabel.Margin = new Padding(4, 0, 4, 0);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new Size(294, 25);
            noteLabel.TabIndex = 4;
            noteLabel.Text = "*Will not open files larger than 2GB.";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 592);
            Controls.Add(noteLabel);
            Controls.Add(outputGroup);
            Controls.Add(selectFileButton);
            Controls.Add(filePathTextBox);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainForm";
            Text = "Hexer File Viewer";
            outputGroup.ResumeLayout(false);
            outputGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog;
        private TextBox filePathTextBox;
        private Button selectFileButton;
        private TextBox outputTextBox;
        private GroupBox outputGroup;
        private Label noteLabel;
    }
}