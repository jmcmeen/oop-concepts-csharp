namespace _04_8_CircleClaculator
{
    partial class CircleForm
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
            radiusTextBox = new TextBox();
            radiusLabel = new Label();
            areaLabel = new Label();
            areaTextBox = new TextBox();
            SuspendLayout();
            // 
            // radiusTextBox
            // 
            radiusTextBox.Location = new Point(74, 10);
            radiusTextBox.Name = "radiusTextBox";
            radiusTextBox.Size = new Size(280, 27);
            radiusTextBox.TabIndex = 1;
            radiusTextBox.TextChanged += radiusTextBox_TextChanged;
            // 
            // radiusLabel
            // 
            radiusLabel.AutoSize = true;
            radiusLabel.Location = new Point(12, 13);
            radiusLabel.Name = "radiusLabel";
            radiusLabel.Size = new Size(56, 20);
            radiusLabel.TabIndex = 2;
            radiusLabel.Text = "Radius:";
            // 
            // areaLabel
            // 
            areaLabel.AutoSize = true;
            areaLabel.Location = new Point(12, 48);
            areaLabel.Name = "areaLabel";
            areaLabel.Size = new Size(43, 20);
            areaLabel.TabIndex = 3;
            areaLabel.Text = "Area:";
            // 
            // areaTextBox
            // 
            areaTextBox.Location = new Point(74, 45);
            areaTextBox.Name = "areaTextBox";
            areaTextBox.Size = new Size(280, 27);
            areaTextBox.TabIndex = 4;
            areaTextBox.TextChanged += areaTextBox_TextChanged;
            // 
            // CircleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 87);
            Controls.Add(areaTextBox);
            Controls.Add(areaLabel);
            Controls.Add(radiusLabel);
            Controls.Add(radiusTextBox);
            Name = "CircleForm";
            Text = "Circle Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button calculateButton;
        private TextBox radiusTextBox;
        private Label radiusLabel;
        private Label areaLabel;
        private TextBox areaTextBox;
    }
}
