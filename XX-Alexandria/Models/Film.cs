using XX_Alexandria.Models;

namespace XX_Alexandria.Models
{
    internal class Film : CatalogItem
    {
        public string Director { get; set; }
        public FilmType FilmType { get; set; }
        public Film(string id, string title, string year, string director, FilmType filmType) : base(id, title, year)
        {
            Director = director;
            FilmType = filmType;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Film {{ Director: {Director} Type: {FilmType} }}";
        }

    }
}
