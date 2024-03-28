namespace _11_2_ModelViewPresenter.View
{
    partial class SpeciesForm
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
            GroupBox groupBox1;
            tableLayoutPanel2 = new TableLayoutPanel();
            sciNameLabel = new Label();
            sciNameTextBox = new TextBox();
            comNameTextBox = new TextBox();
            comNameLabel = new Label();
            editButton = new Button();
            speciesListBox = new ListBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Controls.Add(editButton);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(298, 4);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(343, 268);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Species Info";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(sciNameLabel, 0, 0);
            tableLayoutPanel2.Controls.Add(sciNameTextBox, 1, 0);
            tableLayoutPanel2.Controls.Add(comNameTextBox, 1, 1);
            tableLayoutPanel2.Controls.Add(comNameLabel, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(3, 24);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.MinimumSize = new Size(334, 159);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanel2.Size = new Size(337, 159);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // sciNameLabel
            // 
            sciNameLabel.AutoSize = true;
            sciNameLabel.Location = new Point(5, 6);
            sciNameLabel.Margin = new Padding(5, 6, 5, 6);
            sciNameLabel.Name = "sciNameLabel";
            sciNameLabel.Size = new Size(116, 20);
            sciNameLabel.TabIndex = 2;
            sciNameLabel.Text = "Scientific Name:";
            // 
            // sciNameTextBox
            // 
            sciNameTextBox.Dock = DockStyle.Fill;
            sciNameTextBox.Location = new Point(130, 4);
            sciNameTextBox.Margin = new Padding(3, 4, 3, 4);
            sciNameTextBox.Name = "sciNameTextBox";
            sciNameTextBox.ReadOnly = true;
            sciNameTextBox.Size = new Size(257, 27);
            sciNameTextBox.TabIndex = 3;
            // 
            // comNameTextBox
            // 
            comNameTextBox.Dock = DockStyle.Fill;
            comNameTextBox.Location = new Point(130, 83);
            comNameTextBox.Margin = new Padding(3, 4, 3, 4);
            comNameTextBox.Name = "comNameTextBox";
            comNameTextBox.ReadOnly = true;
            comNameTextBox.Size = new Size(257, 27);
            comNameTextBox.TabIndex = 4;
            // 
            // comNameLabel
            // 
            comNameLabel.AutoSize = true;
            comNameLabel.Location = new Point(5, 85);
            comNameLabel.Margin = new Padding(5, 6, 5, 6);
            comNameLabel.Name = "comNameLabel";
            comNameLabel.Size = new Size(117, 20);
            comNameLabel.TabIndex = 1;
            comNameLabel.Text = "Common Name:";
            // 
            // editButton
            // 
            editButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editButton.Location = new Point(256, 231);
            editButton.Margin = new Padding(3, 4, 3, 4);
            editButton.Name = "editButton";
            editButton.Size = new Size(75, 29);
            editButton.TabIndex = 6;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // speciesListBox
            // 
            speciesListBox.Dock = DockStyle.Fill;
            speciesListBox.FormattingEnabled = true;
            speciesListBox.Location = new Point(3, 4);
            speciesListBox.Margin = new Padding(3, 4, 3, 4);
            speciesListBox.Name = "speciesListBox";
            speciesListBox.Size = new Size(289, 268);
            speciesListBox.TabIndex = 0;
            speciesListBox.SelectedIndexChanged += speciesListBox_SelectedIndexChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(speciesListBox, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(644, 276);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // SpeciesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 276);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(662, 321);
            Name = "SpeciesForm";
            Text = "Species";
            groupBox1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox speciesListBox;
        private System.Windows.Forms.TextBox comNameTextBox;
        private System.Windows.Forms.TextBox sciNameTextBox;
        private System.Windows.Forms.Label sciNameLabel;
        private System.Windows.Forms.Label comNameLabel;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

