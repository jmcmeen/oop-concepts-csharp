using System.ComponentModel;

namespace MediaPlayer
{
    public partial class WavPlayer : Form
    {
        public WavPlayer()
        {
            // Initialize Forms Designer generated code.
            InitializeComponent();

            // Disable playback and load controls until a valid .wav file is selected
            EnablePlaybackControls(false);
            EnableLoadControls(false);

            // Set up the SoundPlayer object.
            InitializeSound();
        }

        // Sets up the SoundPlayer object.
        private void InitializeSound()
        {
            // Create an instance of the SoundPlayer class.
            player = new System.Media.SoundPlayer();

            // Listen for the LoadCompleted event.
            player.LoadCompleted += player_LoadCompleted!;

            // Listen for the SoundLocationChanged event.
            player.SoundLocationChanged += player_LocationChanged!;
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            // Create a new OpenFileDialog.
            OpenFileDialog dlg = new OpenFileDialog();

            // Make sure the dialog checks for existence of the 
            // selected file.
            dlg.CheckFileExists = true;

            // Allow selection of .wav files only.
            dlg.Filter = "WAV files (*.wav)|*.wav";
            dlg.DefaultExt = ".wav";

            // Set default open dir to executable path
            dlg.InitialDirectory = Application.StartupPath;

            // Activate the file selection dialog.
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file's path from the dialog.
                this.filepathTextbox.Text = dlg.FileName;

                // Assign the selected file's path to 
                // the SoundPlayer object.  
                player.SoundLocation = filepathTextbox.Text;
            }
        }

        // Convenience method for setting message text in 
        // the status bar.
        private void ReportStatus(string statusMessage)
        {
            // If the caller passed in a message...
            if (!string.IsNullOrEmpty(statusMessage))
            {
                // ...post the caller's message to the status bar.
                this.toolStripStatusLabel1.Text = statusMessage;
            }
        }

        // Enables and disables play controls.
        private void EnablePlaybackControls(bool enabled)
        {
            this.playOnceSyncButton.Enabled = enabled;
            this.playOnceAsyncButton.Enabled = enabled;
            this.playLoopAsyncButton.Enabled = enabled;
            this.stopButton.Enabled = enabled;
        }

        private void EnableLoadControls(bool enabled)
        {
            this.loadAsyncButton.Enabled = enabled;
            this.loadSyncButton.Enabled = enabled;
        }

        private void filePathTextbox_TextChanged(object sender, EventArgs e)
        {
            //Enable or disable load controls if the filepath is empty or filled
            EnableLoadControls(!string.IsNullOrEmpty(filepathTextbox.Text));

            // Disable playback controls until the new .wav is loaded.
            EnablePlaybackControls(false);
        }

        private void loadSyncButton_Click(object sender, EventArgs e)
        {
            // Disable playback and load controls until the .wav is 
            // successfully loaded. The LoadCompleted event 
            // handler will enable them.
            EnablePlaybackControls(false);
            EnableLoadControls(false);

            try
            {
                ReportStatus("loading .wav file synchronously");

                // Assign the selected file's path to 
                // the SoundPlayer object.  
                player.SoundLocation = filepathTextbox.Text;

                // Load the .wav file.
                player.Load();

                ReportStatus("wav file loaded successfully");
            }
            catch (Exception ex)
            {
                ReportStatus(ex.Message);
            }
        }

        private void loadAsyncButton_Click(object sender, EventArgs e)
        {
            // Disable playback and load controls until the .wav is 
            // successfully loaded. The LoadCompleted event 
            // handler will enable them.
            EnablePlaybackControls(false);
            EnableLoadControls(false);

            try
            {
                ReportStatus("loading .wav file asynchronously");

                // Assign the selected file's path to 
                // the SoundPlayer object.  
                player.SoundLocation = this.filepathTextbox.Text;

                // Load the .wav file.
                player.LoadAsync();

                ReportStatus(".wav file loaded successfully");
            }
            catch (Exception ex)
            {
                ReportStatus(ex.Message);
            }
        }

        // Synchronously plays the selected .wav file once.
        // If the file is large, UI response will be visibly 
        // affected.
        private void playOnceSyncButton_Click(object sender, EventArgs e)
        {
            ReportStatus("Playing .wav file synchronously.");
            player.PlaySync();
            ReportStatus("Finished playing .wav file synchronously.");
        }

        // Asynchronously plays the selected .wav file once.
        private void playOnceAsyncButton_Click(object sender, EventArgs e)
        {
            ReportStatus("Playing .wav file asynchronously.");
            player.Play();
        }

        // Asynchronously plays the selected .wav file until the user
        // clicks the Stop button.
        private void playLoopAsyncButton_Click(object sender, EventArgs e)
        {
            ReportStatus("Looping .wav file asynchronously.");
            player.PlayLooping();
        }

        // Stops the currently playing .wav file, if any.
        private void stopButton_Click(object sender, EventArgs e)
        {
            player.Stop();
            ReportStatus("Playback stopped by user.");
        }

        // Handler for the LoadCompleted event.
        private void player_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            string message = String.Format("LoadCompleted: {0}",
                this.filepathTextbox.Text);
            ReportStatus(message);
            EnablePlaybackControls(true);
            EnableLoadControls(true);
        }

        // Handler for the SoundLocationChanged event.
        private void player_LocationChanged(object sender, EventArgs e)
        {
            string message = String.Format("SoundLocationChanged: {0}",
                player.SoundLocation);
            ReportStatus(message);
        }
    }
}
