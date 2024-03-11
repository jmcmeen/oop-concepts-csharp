namespace XX_BindingSource
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
            this.components = new System.ComponentModel.Container();
            this.stringListBox = new System.Windows.Forms.ListBox();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.addStringButton = new System.Windows.Forms.Button();
            this.listBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.listBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // stringListBox
            // 
            this.stringListBox.FormattingEnabled = true;
            this.stringListBox.ItemHeight = 15;
            this.stringListBox.Location = new System.Drawing.Point(12, 12);
            this.stringListBox.Name = "stringListBox";
            this.stringListBox.Size = new System.Drawing.Size(120, 94);
            this.stringListBox.TabIndex = 0;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(138, 12);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(100, 23);
            this.inputTextBox.TabIndex = 1;
            // 
            // addStringButton
            // 
            this.addStringButton.Location = new System.Drawing.Point(138, 41);
            this.addStringButton.Name = "addStringButton";
            this.addStringButton.Size = new System.Drawing.Size(75, 23);
            this.addStringButton.TabIndex = 2;
            this.addStringButton.Text = "Add String";
            this.addStringButton.UseVisualStyleBackColor = true;
            this.addStringButton.Click += new System.EventHandler(this.addStringButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 130);
            this.Controls.Add(this.addStringButton);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.stringListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.listBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox stringListBox;
        private TextBox inputTextBox;
        private Button addStringButton;
        private BindingSource listBindingSource;
    }
}