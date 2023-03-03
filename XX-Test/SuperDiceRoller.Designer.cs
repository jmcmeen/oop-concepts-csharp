namespace XX_Test
{
    partial class SuperDiceRoller
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
            this.d4 = new System.Windows.Forms.Button();
            this.d6 = new System.Windows.Forms.Button();
            this.d8 = new System.Windows.Forms.Button();
            this.d10 = new System.Windows.Forms.Button();
            this.d12 = new System.Windows.Forms.Button();
            this.d20 = new System.Windows.Forms.Button();
            this.d100 = new System.Windows.Forms.Button();
            this.dx = new System.Windows.Forms.Button();
            this.x = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // d4
            // 
            this.d4.Location = new System.Drawing.Point(12, 12);
            this.d4.Name = "d4";
            this.d4.Size = new System.Drawing.Size(75, 23);
            this.d4.TabIndex = 0;
            this.d4.Text = "D4";
            this.d4.UseVisualStyleBackColor = true;
            this.d4.Click += new System.EventHandler(this.d4_Click);
            // 
            // d6
            // 
            this.d6.Location = new System.Drawing.Point(93, 12);
            this.d6.Name = "d6";
            this.d6.Size = new System.Drawing.Size(75, 23);
            this.d6.TabIndex = 1;
            this.d6.Text = "D6";
            this.d6.UseVisualStyleBackColor = true;
            this.d6.Click += new System.EventHandler(this.d6_Click);
            // 
            // d8
            // 
            this.d8.Location = new System.Drawing.Point(174, 12);
            this.d8.Name = "d8";
            this.d8.Size = new System.Drawing.Size(75, 23);
            this.d8.TabIndex = 2;
            this.d8.Text = "D8";
            this.d8.UseVisualStyleBackColor = true;
            this.d8.Click += new System.EventHandler(this.d8_Click);
            // 
            // d10
            // 
            this.d10.Location = new System.Drawing.Point(255, 12);
            this.d10.Name = "d10";
            this.d10.Size = new System.Drawing.Size(75, 23);
            this.d10.TabIndex = 3;
            this.d10.Text = "D10";
            this.d10.UseVisualStyleBackColor = true;
            this.d10.Click += new System.EventHandler(this.d10_Click);
            // 
            // d12
            // 
            this.d12.Location = new System.Drawing.Point(336, 12);
            this.d12.Name = "d12";
            this.d12.Size = new System.Drawing.Size(75, 23);
            this.d12.TabIndex = 4;
            this.d12.Text = "D12";
            this.d12.UseVisualStyleBackColor = true;
            this.d12.Click += new System.EventHandler(this.d12_Click);
            // 
            // d20
            // 
            this.d20.Location = new System.Drawing.Point(417, 12);
            this.d20.Name = "d20";
            this.d20.Size = new System.Drawing.Size(75, 23);
            this.d20.TabIndex = 5;
            this.d20.Text = "D20";
            this.d20.UseVisualStyleBackColor = true;
            this.d20.Click += new System.EventHandler(this.d20_Click);
            // 
            // d100
            // 
            this.d100.Location = new System.Drawing.Point(498, 12);
            this.d100.Name = "d100";
            this.d100.Size = new System.Drawing.Size(75, 23);
            this.d100.TabIndex = 6;
            this.d100.Text = "D100";
            this.d100.UseVisualStyleBackColor = true;
            this.d100.Click += new System.EventHandler(this.d100_Click);
            // 
            // dx
            // 
            this.dx.Location = new System.Drawing.Point(579, 12);
            this.dx.Name = "dx";
            this.dx.Size = new System.Drawing.Size(75, 23);
            this.dx.TabIndex = 7;
            this.dx.Text = "Custom";
            this.dx.UseVisualStyleBackColor = true;
            this.dx.Click += new System.EventHandler(this.dx_Click);
            // 
            // x
            // 
            this.x.Location = new System.Drawing.Point(660, 13);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(100, 23);
            this.x.TabIndex = 8;
            this.x.TextChanged += new System.EventHandler(this.x_TextChanged);
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.output.Location = new System.Drawing.Point(255, 43);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(47, 78);
            this.output.TabIndex = 9;
            this.output.Text = " ";
            this.output.Click += new System.EventHandler(this.output_Click);
            // 
            // SuperDiceRoller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 130);
            this.Controls.Add(this.output);
            this.Controls.Add(this.x);
            this.Controls.Add(this.dx);
            this.Controls.Add(this.d100);
            this.Controls.Add(this.d20);
            this.Controls.Add(this.d12);
            this.Controls.Add(this.d10);
            this.Controls.Add(this.d8);
            this.Controls.Add(this.d6);
            this.Controls.Add(this.d4);
            this.Name = "SuperDiceRoller";
            this.Text = "Super Dice Roller!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button d4;
        private Button d6;
        private Button d8;
        private Button d10;
        private Button d12;
        private Button d20;
        private Button d100;
        private Button dx;
        private TextBox x;
        private Label output;
    }
}