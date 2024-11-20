using System.Xml.Serialization;

namespace _11_2_ModelViewPresenter.Model
{
    internal class SpeciesXmlRepository : ISpeciesRepository
    {
        private readonly string _xmlFilePath;
        private readonly XmlSerializer _serializer = new XmlSerializer(typeof(List<Species>));
        private readonly Lazy<List<Species>> _species;

        public SpeciesXmlRepository(string fullPath)
        {
            _xmlFilePath = fullPath + @"\species.xml";

            if (!File.Exists(_xmlFilePath))
                CreateSpeciesXmlStub();

            _species = new Lazy<List<Species>>(() =>
            {
                using (var reader = new StreamReader(_xmlFilePath))
                {
                    return (List<Species>)_serializer.Deserialize(reader)!;
                }
            });
        }

        /// <summary>
        /// Creates starter data if no file is found. Ideally you wouldn't have this in 
        /// production code, you would wire it up to a prod file or DB but this is a demonstration. 
        /// </summary>
        private void CreateSpeciesXmlStub()
        {
            var stubSpeciesList = new List<Species> {
                new Species {ScientificName = "Anaxyrus americanus americanus", CommonName = "American Toad"},
                new Species {ScientificName = "Anaxyrus fowleri", CommonName = "Fowler's Toad"},
                new Species {ScientificName = "Hyla chrysoscelis", CommonName = "Cope's Gray Treefrog"},
                new Species {ScientificName = "Lithobates catesbeianus", CommonName = "American Bullfrog"},
                new Species {ScientificName = "Lithobates clamitans", CommonName = "Green Frog"},
                new Species {ScientificName = "Lithobates palustris", CommonName = "Pickerel Frog"},
                new Species {ScientificName = "Lithobates sphenocephalus", CommonName = "Southern Leopard Frog"},
                new Species {ScientificName = "Lithobates sylvaticus", CommonName = "Wood Frog"},
                new Species {ScientificName = "Pseudacris crucifer", CommonName = "Spring Peeper"},
                new Species {ScientificName = "Pseudacris feriarum", CommonName = "Upland Chorus Frog"},
            };
            SaveSpeciesList(stubSpeciesList);
        }

        private void SaveSpeciesList(List<Species> species)
        {
            using (var writer = new StreamWriter(_xmlFilePath, false))
            {
                _serializer.Serialize(writer, species);
            }
        }

        public IEnumerable<Species> GetAllSpecies()
        {
            return _species.Value;
        }

        public Species GetSpecies(int id)
        {
            return _species.Value[id];
        }

        public void SaveSpecies(int id, Species species)
        {
            _species.Value[id] = species;
            SaveSpeciesList(_species.Value);
        }
    }
}