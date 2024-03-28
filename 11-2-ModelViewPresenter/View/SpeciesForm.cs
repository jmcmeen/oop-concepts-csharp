using _11_2_ModelViewPresenter.Presenter;

namespace _11_2_ModelViewPresenter.View
{
    internal partial class SpeciesForm : Form, ISpeciesView
    {
        private bool _isEditMode = false;

        public SpeciesForm()
        {
            InitializeComponent();
        }

        public IList<string> speciesList
        {
            get { return (IList<string>)this.speciesListBox.DataSource; }
            set { this.speciesListBox.DataSource = value; }
        }

        public int SelectedSpecies
        {
            get { return this.speciesListBox.SelectedIndex; }
            set { this.speciesListBox.SelectedIndex = value; }
        }

        public string CommonName
        {
            get { return this.comNameTextBox.Text; }
            set { this.comNameTextBox.Text = value; }
        }

        public string ScientificName
        {
            get { return this.sciNameTextBox.Text; }
            set { this.sciNameTextBox.Text = value; }
        }

        public SpeciesPresenter Presenter
        { private get; set; }

        private void speciesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // FIXME: try/catch
            Presenter.UpdateSpeciesView(speciesListBox.SelectedIndex);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            this.comNameTextBox.ReadOnly = _isEditMode;
            this.sciNameTextBox.ReadOnly = _isEditMode;

            _isEditMode = !_isEditMode;

            this.editButton.Text = _isEditMode ? "Save" : "Edit";
            // TODO: add cancel button

            if (!_isEditMode)
            {
                // TODO: validation
                // FIXME: try/catch
                Presenter.SaveSpecies();
            }
        }
    }
}