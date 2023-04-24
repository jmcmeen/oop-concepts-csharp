namespace XX_FileDialog
{
    partial class Form1
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
            filePathTextBox.Location = new Point(12, 12);
            filePathTextBox.Name = "filePathTextBox";
            filePathTextBox.ReadOnly = true;
            filePathTextBox.Size = new Size(453, 23);
            filePathTextBox.TabIndex = 0;
            // 
            // selectFileButton
            // 
            selectFileButton.Location = new Point(471, 12);
            selectFileButton.Name = "selectFileButton";
            selectFileButton.Size = new Size(75, 23);
            selectFileButton.TabIndex = 1;
            selectFileButton.Text = "Select File";
            selectFileButton.UseVisualStyleBackColor = true;
            selectFileButton.Click += selectFileButton_Click;
            // 
            // outputTextBox
            // 
            outputTextBox.Location = new Point(6, 22);
            outputTextBox.Multiline = true;
            outputTextBox.Name = "outputTextBox";
            outputTextBox.ScrollBars = ScrollBars.Vertical;
            outputTextBox.Size = new Size(521, 248);
            outputTextBox.TabIndex = 2;
            // 
            // outputGroup
            // 
            outputGroup.Controls.Add(outputTextBox);
            outputGroup.Location = new Point(13, 54);
            outputGroup.Name = "outputGroup";
            outputGroup.Size = new Size(533, 276);
            outputGroup.TabIndex = 3;
            outputGroup.TabStop = false;
            outputGroup.Text = "Hex";
            // 
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.Location = new Point(16, 344);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new Size(260, 15);
            noteLabel.TabIndex = 4;
            noteLabel.Text = "It is not advised to open large files with this app.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 381);
            Controls.Add(noteLabel);
            Controls.Add(outputGroup);
            Controls.Add(selectFileButton);
            Controls.Add(filePathTextBox);
            Name = "Form1";
            Text = "Hexer";
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