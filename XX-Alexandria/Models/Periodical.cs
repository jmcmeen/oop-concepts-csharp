using XX_Alexandria.Models;

namespace XX_Alexandria.Models
{
    internal class Periodical : CatalogItem
    {
        public string Volume { get; set; }
        public string Issue { get; set; }

        public PeriodicalType PeriodicalType { get; set; }

        public Periodical(string id, string title, string year, string volume, string issue, PeriodicalType periodicalType) : base(id, title, year)
        {
            Volume = volume;
            Issue = issue;
            PeriodicalType = periodicalType;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Periodical {{ Volume: {Volume} Issue: {Issue} Type: {PeriodicalType} }}";
        }
    }
}
