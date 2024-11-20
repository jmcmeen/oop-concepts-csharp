using _11_2_ModelViewPresenter.Presenter;

namespace _11_2_ModelViewPresenter.View
{
    public interface ISpeciesView
    {
        IList<string>? SpeciesList { get; set; }

        int SelectedSpecies { get; set; }

        string? ScientificName { get; set; }

        string? CommonName { get; set; }

        SpeciesPresenter? Presenter { set; }
    }
}