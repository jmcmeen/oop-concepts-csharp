using System.Media;

namespace MediaPlayer
{
    partial class WavPlayer
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
        private void InitializeComponent()
        {
            filepathTextbox = new TextBox();
            selectFileButton = new Button();
            loadSyncButton = new Button();
            playOnceSyncButton = new Button();
            playOnceAsyncButton = new Button();
            stopButton = new Button();
            playLoopAsyncButton = new Button();
            loadAsyncButton = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            pathLabel = new Label();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // filepathTextbox
            // 
            filepathTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            filepathTextbox.Location = new Point(7, 27);
            filepathTextbox.Name = "filepathTextbox";
            filepathTextbox.Size = new Size(483, 27);
            filepathTextbox.TabIndex = 1;
            filepathTextbox.TextChanged += filePathTextbox_TextChanged;
            // 
            // selectFileButton
            // 
            selectFileButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            selectFileButton.Location = new Point(496, 27);
            selectFileButton.Name = "selectFileButton";
            selectFileButton.Size = new Size(72, 29);
            selectFileButton.TabIndex = 2;
            selectFileButton.Text = "...";
            selectFileButton.Click += selectFileButton_Click;
            // 
            // loadSyncButton
            // 
            loadSyncButton.Location = new Point(7, 60);
            loadSyncButton.Name = "loadSyncButton";
            loadSyncButton.Size = new Size(272, 47);
            loadSyncButton.TabIndex = 4;
            loadSyncButton.Text = "Load Synchronously";
            loadSyncButton.Click += loadSyncButton_Click;
            // 
            // playOnceSyncButton
            // 
            playOnceSyncButton.Location = new Point(7, 113);
            playOnceSyncButton.Name = "playOnceSyncButton";
            playOnceSyncButton.Size = new Size(272, 47);
            playOnceSyncButton.TabIndex = 5;
            playOnceSyncButton.Text = "Play Once Synchronously";
            playOnceSyncButton.Click += playOnceSyncButton_Click;
            // 
            // playOnceAsyncButton
            // 
            playOnceAsyncButton.Location = new Point(285, 111);
            playOnceAsyncButton.Name = "playOnceAsyncButton";
            playOnceAsyncButton.Size = new Size(283, 47);
            playOnceAsyncButton.TabIndex = 6;
            playOnceAsyncButton.Text = "Play Once Asynchronously";
            playOnceAsyncButton.Click += playOnceAsyncButton_Click;
            // 
            // stopButton
            // 
            stopButton.Location = new Point(285, 217);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(283, 47);
            stopButton.TabIndex = 7;
            stopButton.Text = "Stop";
            stopButton.Click += stopButton_Click;
            // 
            // playLoopAsyncButton
            // 
            playLoopAsyncButton.Location = new Point(285, 164);
            playLoopAsyncButton.Name = "playLoopAsyncButton";
            playLoopAsyncButton.Size = new Size(283, 47);
            playLoopAsyncButton.TabIndex = 8;
            playLoopAsyncButton.Text = "Loop Asynchronously";
            playLoopAsyncButton.Click += playLoopAsyncButton_Click;
            // 
            // loadAsyncButton
            // 
            loadAsyncButton.Location = new Point(285, 60);
            loadAsyncButton.Name = "loadAsyncButton";
            loadAsyncButton.Size = new Size(283, 47);
            loadAsyncButton.TabIndex = 10;
            loadAsyncButton.Text = "Load Asynchronously";
            loadAsyncButton.Click += loadAsyncButton_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 282);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(577, 26);
            statusStrip1.TabIndex = 11;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(50, 20);
            toolStripStatusLabel1.Text = "Ready";
            // 
            // pathLabel
            // 
            pathLabel.AutoSize = true;
            pathLabel.Location = new Point(12, 4);
            pathLabel.Name = "pathLabel";
            pathLabel.Size = new Size(149, 20);
            pathLabel.TabIndex = 12;
            pathLabel.Text = ".wav file path or URL ";
            // 
            // WavPlayer
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(577, 308);
            Controls.Add(pathLabel);
            Controls.Add(statusStrip1);
            Controls.Add(loadAsyncButton);
            Controls.Add(playLoopAsyncButton);
            Controls.Add(stopButton);
            Controls.Add(playOnceAsyncButton);
            Controls.Add(playOnceSyncButton);
            Controls.Add(loadSyncButton);
            Controls.Add(selectFileButton);
            Controls.Add(filepathTextbox);
            MinimumSize = new Size(310, 165);
            Name = "WavPlayer";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "WavPlayer";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox filepathTextbox;
        private System.Windows.Forms.Button playOnceSyncButton;
        private System.Windows.Forms.Button playOnceAsyncButton;
        private System.Windows.Forms.Button playLoopAsyncButton;
        private System.Windows.Forms.Button selectFileButton;

        private System.Windows.Forms.Button stopButton;
        //private System.Windows.Forms.StatusBar statusBar;
        private System.Windows.Forms.Button loadSyncButton;
        private System.Windows.Forms.Button loadAsyncButton;
        private System.Media.SoundPlayer player;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Label pathLabel;
    }
}
#endregion