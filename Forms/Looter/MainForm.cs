using SampleClasses;
using System.Text.Json;

namespace BindingSource
{
    public partial class MainForm : Form
    {
        private LootFile? LootFile { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void removeLootButton_Click(object sender, EventArgs e)
        {
            int index = lootListBox.SelectedIndex;

            if (index != -1)
            {
                LootFile.loots.RemoveAt(index);
                LootFile.Saved = false;
            }

            lootListBindingSource.ResetBindings(true);
        }

        private void addLootButton_Click(object sender, EventArgs e)
        {
            if(nameTextBox.Text == string.Empty)
            {
                toolStripStatusLabel.Text = "Name can not be blank!";
                toolStripStatusLabel.ForeColor = Color.Red;
            }
            else if (priceTextBox.Text ==  string.Empty) 
            {
                toolStripStatusLabel.Text = "Price can not be blank!";
                toolStripStatusLabel.ForeColor = Color.Red;
            }
            else if (descriptionTextBox.Text == string.Empty) 
            {
                toolStripStatusLabel.Text = "Description can not be blank!";
                toolStripStatusLabel.ForeColor = Color.Red;
            }
            else
            {
                try
                {
                    uint price = Convert.ToUInt32(priceTextBox.Text);

                    Loot l = new Loot()
                    {
                        Name = nameTextBox.Text,
                        Description = descriptionTextBox.Text,
                        Price = price
                    };

                    LootFile.loots.Add(l);
                    LootFile.loots.Sort();
                    LootFile.Saved = false;
                    LootFile.NewFile = false;
                    lootListBindingSource.ResetBindings(true);
                    nameTextBox.Text = string.Empty;
                    priceTextBox.Text = string.Empty;
                    descriptionTextBox.Text = string.Empty;
                    nameTextBox.Focus();
                }
                catch (FormatException) 
                {
                    toolStripStatusLabel.Text = "Price must be a whole number!";
                    toolStripStatusLabel.ForeColor = Color.Red;
                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LootFile == null)
            {
                LootFile = new LootFile();
                lootListBindingSource.DataSource = LootFile.loots;
                lootListBox.DataSource = lootListBindingSource;

                mainPanel.Visible = true;
                saveToolStripMenuItem.Enabled = true;
                saveAsToolStripMenuItem.Enabled = true;
                closeToolStripMenuItem.Enabled = true;
            }
            else if (LootFile != null)
            {
                if (LootFile.Saved)
                {
                    LootFile = new LootFile();
                    lootListBindingSource.DataSource = LootFile.loots;
                    lootListBox.DataSource = lootListBindingSource;
                }
                else
                {
                    if (!LootFile.Saved && LootFile.loots.Count > 0)
                    {
                        DialogResult dialogResult = MessageBox.Show("You have unsaved data. Do you want to save?", "Warning", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            this.saveAsToolStripMenuItem_Click(sender, e);
                        }
                    }
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(LootFile != null)
            {
                if (!LootFile.Saved && !LootFile.NewFile )
                {
                    DialogResult dialogResult = MessageBox.Show("You have unsaved data. Do you want to save?", "Warning", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        this.saveAsToolStripMenuItem_Click(sender, e);
                    }
                }

                openFileDialog.ShowDialog();
                if (openFileDialog.FileName != string.Empty)
                {
                    try
                    {
                        string json = File.ReadAllText(openFileDialog.FileName);
                        LootFile = new LootFile()
                        {
                            Saved = true,
                            Path = openFileDialog.FileName,
                            loots = JsonSerializer.Deserialize<List<Loot>>(json)
                        };

                        lootListBindingSource.DataSource = LootFile.loots;
                        lootListBox.DataSource = lootListBindingSource;
                        lootListBindingSource.ResetBindings(true);

                        mainPanel.Visible = true;
                        saveToolStripMenuItem.Enabled = true;
                        saveAsToolStripMenuItem.Enabled = true;
                        closeToolStripMenuItem.Enabled = true;
                    }
                    catch (Exception)
                    {
                        toolStripStatusLabel.Text = "File read error";
                        toolStripStatusLabel.ForeColor = Color.Red;
                    }
                }
            }
            else
            {
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string json = File.ReadAllText(openFileDialog.FileName);
                        LootFile = new LootFile()
                        {
                            Saved = true,
                            Path = openFileDialog.FileName,
                            loots = JsonSerializer.Deserialize<List<Loot>>(json),
                            NewFile = false
                        };

                        lootListBindingSource.DataSource = LootFile.loots;
                        lootListBox.DataSource = lootListBindingSource;
                        lootListBindingSource.ResetBindings(true);

                        mainPanel.Visible = true;
                        saveToolStripMenuItem.Enabled = true;
                        saveAsToolStripMenuItem.Enabled = true;
                        closeToolStripMenuItem.Enabled = true;
                    }
                    catch (Exception)
                    {
                        toolStripStatusLabel.Text = "File read error";
                        toolStripStatusLabel.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!LootFile.Saved && !LootFile.NewFile)
            {
                DialogResult dialogResult = MessageBox.Show("You have unsaved data. Do you want to save?", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.saveAsToolStripMenuItem_Click(sender, e);
                }

                LootFile = null;
                mainPanel.Visible = false;
                saveToolStripMenuItem.Enabled = false;
                saveAsToolStripMenuItem.Enabled = false;
                closeToolStripMenuItem.Enabled = false;
                
            }
            else
            {
                LootFile = null;
                mainPanel.Visible = false;
                saveToolStripMenuItem.Enabled = false;
                saveAsToolStripMenuItem.Enabled = false;
                closeToolStripMenuItem.Enabled = false;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LootFile.Path == string.Empty)
            {                
                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    LootFile.Path = saveFileDialog.FileName;
                    File.WriteAllText(LootFile.Path, JsonSerializer.Serialize(LootFile.loots));
                    LootFile.Saved = true;
                }
            }
            else
            {
                File.WriteAllText(LootFile.Path, JsonSerializer.Serialize(LootFile.loots));
                LootFile.Saved = true;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                LootFile.Path = saveFileDialog.FileName;
                File.WriteAllText(LootFile.Path, JsonSerializer.Serialize(LootFile.loots));
                LootFile.Saved = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LootFile != null)
            {
                if (!LootFile.Saved && !LootFile.NewFile)
                {
                    DialogResult dialogResult = MessageBox.Show("You have unsaved data. Do you want to save?", "Warning", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        this.saveAsToolStripMenuItem_Click(sender, e);
                    }
                }
            }

            Environment.Exit(0);
        }

        private void looterV10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            mainPanel.Visible = false;
            saveToolStripMenuItem.Enabled = false;
            saveAsToolStripMenuItem.Enabled = false;
            closeToolStripMenuItem.Enabled = false;
        }
    }
}
