namespace _00_1_HelloForms
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
            revealFortuneButton = new Button();
            fortuneLabel = new Label();
            SuspendLayout();
            // 
            // revealFortuneButton
            // 
            revealFortuneButton.Location = new Point(12, 12);
            revealFortuneButton.Name = "revealFortuneButton";
            revealFortuneButton.Size = new Size(242, 23);
            revealFortuneButton.TabIndex = 0;
            revealFortuneButton.Text = "Reveal Your Fortune";
            revealFortuneButton.UseVisualStyleBackColor = true;
            revealFortuneButton.Click += revealFortuneButton_Click;
            // 
            // fortuneLabel
            // 
            fortuneLabel.Location = new Point(12, 38);
            fortuneLabel.Name = "fortuneLabel";
            fortuneLabel.Size = new Size(242, 15);
            fortuneLabel.TabIndex = 1;
            fortuneLabel.Text = "fortune";
            fortuneLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 60);
            Controls.Add(fortuneLabel);
            Controls.Add(revealFortuneButton);
            Name = "MainForm";
            Text = "Hello Forms";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button revealFortuneButton;
        private Label fortuneLabel;
    }
}
