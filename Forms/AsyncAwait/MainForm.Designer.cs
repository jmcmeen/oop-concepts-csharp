namespace AsyncAwait
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnMainThread = new Button();
            prgMainThread = new ProgressBar();
            badLabel = new Label();
            betterLabel = new Label();
            prgSeparateThread = new ProgressBar();
            btnSeparateThread = new Button();
            evenBetterLabel = new Label();
            prgMultipleThreads = new ProgressBar();
            btnMultipleThreads = new Button();
            bestLabel = new Label();
            prgMultipleThreadsHeavy = new ProgressBar();
            btnMultipleThreadsHeavy = new Button();
            txtMainThread = new TextBox();
            txtSeparateThread = new TextBox();
            txtMultipleThreads = new TextBox();
            txtMultipleThreadsHeavy = new TextBox();
            SuspendLayout();
            // 
            // btnMainThread
            // 
            btnMainThread.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMainThread.Location = new Point(12, 12);
            btnMainThread.Name = "btnMainThread";
            btnMainThread.Size = new Size(280, 57);
            btnMainThread.TabIndex = 0;
            btnMainThread.Text = "Run on Main Thread\r\n( locks everything.. boo 👎 )";
            btnMainThread.UseVisualStyleBackColor = true;
            btnMainThread.Click += btnMainThread_Click;
            // 
            // prgMainThread
            // 
            prgMainThread.Location = new Point(12, 75);
            prgMainThread.Name = "prgMainThread";
            prgMainThread.Size = new Size(280, 29);
            prgMainThread.TabIndex = 1;
            prgMainThread.Visible = false;
            // 
            // badLabel
            // 
            badLabel.Location = new Point(12, 377);
            badLabel.Name = "badLabel";
            badLabel.Size = new Size(280, 106);
            badLabel.TabIndex = 3;
            badLabel.Text = "Running everything on the main thread locks up the UI. Notice how nothing else is responsive until it's finished.";
            // 
            // betterLabel
            // 
            betterLabel.Location = new Point(298, 377);
            betterLabel.Name = "betterLabel";
            betterLabel.Size = new Size(280, 149);
            betterLabel.TabIndex = 7;
            betterLabel.Text = resources.GetString("betterLabel.Text");
            // 
            // prgSeparateThread
            // 
            prgSeparateThread.Location = new Point(298, 75);
            prgSeparateThread.Name = "prgSeparateThread";
            prgSeparateThread.Size = new Size(280, 29);
            prgSeparateThread.Style = ProgressBarStyle.Marquee;
            prgSeparateThread.TabIndex = 5;
            prgSeparateThread.Visible = false;
            // 
            // btnSeparateThread
            // 
            btnSeparateThread.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSeparateThread.Location = new Point(298, 12);
            btnSeparateThread.Name = "btnSeparateThread";
            btnSeparateThread.Size = new Size(280, 57);
            btnSeparateThread.TabIndex = 4;
            btnSeparateThread.Text = "Run on Separate Thread\r\n( ui is still responsive! 👍 )\r\n";
            btnSeparateThread.UseVisualStyleBackColor = true;
            btnSeparateThread.Click += btnSeparateThread_Click;
            // 
            // evenBetterLabel
            // 
            evenBetterLabel.Location = new Point(584, 377);
            evenBetterLabel.Name = "evenBetterLabel";
            evenBetterLabel.Size = new Size(280, 129);
            evenBetterLabel.TabIndex = 11;
            evenBetterLabel.Text = resources.GetString("evenBetterLabel.Text");
            // 
            // prgMultipleThreads
            // 
            prgMultipleThreads.Location = new Point(584, 75);
            prgMultipleThreads.Name = "prgMultipleThreads";
            prgMultipleThreads.Size = new Size(280, 29);
            prgMultipleThreads.Style = ProgressBarStyle.Marquee;
            prgMultipleThreads.TabIndex = 9;
            prgMultipleThreads.Visible = false;
            // 
            // btnMultipleThreads
            // 
            btnMultipleThreads.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMultipleThreads.Location = new Point(584, 12);
            btnMultipleThreads.Name = "btnMultipleThreads";
            btnMultipleThreads.Size = new Size(280, 57);
            btnMultipleThreads.TabIndex = 8;
            btnMultipleThreads.Text = "Run on Multiple Threads (easy win)\r\n( so much fastness! 🏃‍♂️💨 )\r\n";
            btnMultipleThreads.UseVisualStyleBackColor = true;
            btnMultipleThreads.Click += btnMultipleThreads_Click;
            // 
            // bestLabel
            // 
            bestLabel.Location = new Point(870, 377);
            bestLabel.Name = "bestLabel";
            bestLabel.Size = new Size(280, 90);
            bestLabel.TabIndex = 15;
            bestLabel.Text = "Finally, with some heavy refactoring (the BreakfastHeavilyDigested class), where nearly everything has been changed to async, you get the best results.";
            // 
            // prgMultipleThreadsHeavy
            // 
            prgMultipleThreadsHeavy.Location = new Point(870, 75);
            prgMultipleThreadsHeavy.Name = "prgMultipleThreadsHeavy";
            prgMultipleThreadsHeavy.Size = new Size(280, 29);
            prgMultipleThreadsHeavy.Style = ProgressBarStyle.Marquee;
            prgMultipleThreadsHeavy.TabIndex = 13;
            prgMultipleThreadsHeavy.Visible = false;
            // 
            // btnMultipleThreadsHeavy
            // 
            btnMultipleThreadsHeavy.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMultipleThreadsHeavy.Location = new Point(870, 12);
            btnMultipleThreadsHeavy.Name = "btnMultipleThreadsHeavy";
            btnMultipleThreadsHeavy.Size = new Size(280, 57);
            btnMultipleThreadsHeavy.TabIndex = 12;
            btnMultipleThreadsHeavy.Text = "Run on Multiple Threads (heavy refactor)\r\n( even more fastness! 🏃‍♂️💨 💨 )";
            btnMultipleThreadsHeavy.UseVisualStyleBackColor = true;
            btnMultipleThreadsHeavy.Click += btnMultipleThreadsHeavy_Click;
            // 
            // txtMainThread
            // 
            txtMainThread.Location = new Point(12, 110);
            txtMainThread.Multiline = true;
            txtMainThread.Name = "txtMainThread";
            txtMainThread.ScrollBars = ScrollBars.Vertical;
            txtMainThread.Size = new Size(280, 264);
            txtMainThread.TabIndex = 16;
            // 
            // txtSeparateThread
            // 
            txtSeparateThread.Location = new Point(298, 110);
            txtSeparateThread.Multiline = true;
            txtSeparateThread.Name = "txtSeparateThread";
            txtSeparateThread.ScrollBars = ScrollBars.Vertical;
            txtSeparateThread.Size = new Size(280, 264);
            txtSeparateThread.TabIndex = 17;
            // 
            // txtMultipleThreads
            // 
            txtMultipleThreads.Location = new Point(584, 110);
            txtMultipleThreads.Multiline = true;
            txtMultipleThreads.Name = "txtMultipleThreads";
            txtMultipleThreads.ScrollBars = ScrollBars.Vertical;
            txtMultipleThreads.Size = new Size(280, 264);
            txtMultipleThreads.TabIndex = 18;
            // 
            // txtMultipleThreadsHeavy
            // 
            txtMultipleThreadsHeavy.Location = new Point(870, 110);
            txtMultipleThreadsHeavy.Multiline = true;
            txtMultipleThreadsHeavy.Name = "txtMultipleThreadsHeavy";
            txtMultipleThreadsHeavy.ScrollBars = ScrollBars.Vertical;
            txtMultipleThreadsHeavy.Size = new Size(280, 264);
            txtMultipleThreadsHeavy.TabIndex = 19;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1161, 536);
            Controls.Add(txtMultipleThreadsHeavy);
            Controls.Add(txtMultipleThreads);
            Controls.Add(txtSeparateThread);
            Controls.Add(txtMainThread);
            Controls.Add(bestLabel);
            Controls.Add(prgMultipleThreadsHeavy);
            Controls.Add(btnMultipleThreadsHeavy);
            Controls.Add(evenBetterLabel);
            Controls.Add(prgMultipleThreads);
            Controls.Add(btnMultipleThreads);
            Controls.Add(betterLabel);
            Controls.Add(prgSeparateThread);
            Controls.Add(btnSeparateThread);
            Controls.Add(badLabel);
            Controls.Add(prgMainThread);
            Controls.Add(btnMainThread);
            Name = "MainForm";
            Text = "AsyncAwait";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMainThread;
        private ProgressBar prgMainThread;
        private Label badLabel;
        private Label betterLabel;
        private ProgressBar prgSeparateThread;
        private Button btnSeparateThread;
        private Label evenBetterLabel;
        private ProgressBar prgMultipleThreads;
        private Button btnMultipleThreads;
        private Label bestLabel;
        private ProgressBar prgMultipleThreadsHeavy;
        private Button btnMultipleThreadsHeavy;
        private TextBox txtMainThread;
        private TextBox txtSeparateThread;
        private TextBox txtMultipleThreads;
        private TextBox txtMultipleThreadsHeavy;
    }
}
