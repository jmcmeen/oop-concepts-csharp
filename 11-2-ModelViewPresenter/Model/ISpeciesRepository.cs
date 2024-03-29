namespace _11_2_ModelViewPresenter.Model
{
    public interface ISpeciesRepository
    {
        IEnumerable<Species> GetAllSpecies();

        Species GetSpecies(int id);

        void SaveSpecies(int id, Species species);
    }
}
