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
            filePathTextBox.Location = new Point(14, 16);
            filePathTextBox.Margin = new Padding(3, 4, 3, 4);
            filePathTextBox.Name = "filePathTextBox";
            filePathTextBox.ReadOnly = true;
            filePathTextBox.Size = new Size(517, 27);
            filePathTextBox.TabIndex = 0;
            // 
            // selectFileButton
            // 
            selectFileButton.Location = new Point(538, 16);
            selectFileButton.Margin = new Padding(3, 4, 3, 4);
            selectFileButton.Name = "selectFileButton";
            selectFileButton.Size = new Size(86, 31);
            selectFileButton.TabIndex = 1;
            selectFileButton.Text = "Select File";
            selectFileButton.UseVisualStyleBackColor = true;
            selectFileButton.Click += selectFileButton_Click;
            // 
            // outputTextBox
            // 
            outputTextBox.Location = new Point(7, 29);
            outputTextBox.Margin = new Padding(3, 4, 3, 4);
            outputTextBox.Multiline = true;
            outputTextBox.Name = "outputTextBox";
            outputTextBox.ReadOnly = true;
            outputTextBox.ScrollBars = ScrollBars.Vertical;
            outputTextBox.Size = new Size(595, 329);
            outputTextBox.TabIndex = 2;
            outputTextBox.WordWrap = false;
            // 
            // outputGroup
            // 
            outputGroup.Controls.Add(outputTextBox);
            outputGroup.Location = new Point(15, 72);
            outputGroup.Margin = new Padding(3, 4, 3, 4);
            outputGroup.Name = "outputGroup";
            outputGroup.Padding = new Padding(3, 4, 3, 4);
            outputGroup.Size = new Size(609, 368);
            outputGroup.TabIndex = 3;
            outputGroup.TabStop = false;
            outputGroup.Text = "Hex";
            // 
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.Location = new Point(15, 444);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new Size(246, 20);
            noteLabel.TabIndex = 4;
            noteLabel.Text = "*Will not open files larger than 2GB.";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 474);
            Controls.Add(noteLabel);
            Controls.Add(outputGroup);
            Controls.Add(selectFileButton);
            Controls.Add(filePathTextBox);
            Margin = new Padding(3, 4, 3, 4);
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