using _11_2_ModelViewPresenter.Model;
using _11_2_ModelViewPresenter.View;

namespace _11_2_ModelViewPresenter.Presenter
{
    public class SpeciesPresenter
    {
        private readonly ISpeciesView _view;
        private readonly ISpeciesRepository _repository;

        public SpeciesPresenter(ISpeciesView view, ISpeciesRepository repository)
        {
            _view = view;
            view.Presenter = this;
            _repository = repository;

            UpdateSpeciesListView();
        }

        private void UpdateSpeciesListView()
        {
            var speciesNames = from species in _repository.GetAllSpecies() select species.ScientificName;
            int selectedSpecies = _view.SelectedSpecies >= 0 ? _view.SelectedSpecies : 0;
            _view.SpeciesList = speciesNames.ToList();
            _view.SelectedSpecies = selectedSpecies;
        }

        public void UpdateSpeciesView(int p)
        {
            // species list can be cached instead of re-fetching the species each time
            // this may be infeasible if the list is large
            Species species = _repository.GetSpecies(p);
            _view.ScientificName = species.ScientificName;
            _view.CommonName = species.CommonName;
        }

        public void SaveSpecies()
        {
            Species species = new Species { ScientificName = _view.ScientificName, CommonName = _view.CommonName };
            _repository.SaveSpecies(_view.SelectedSpecies, species);
            UpdateSpeciesListView();
        }
    }
}