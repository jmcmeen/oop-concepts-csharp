using System.Text;

namespace XX_Alexandria.Models
{
    internal class Catalog
    {
        public string Name { get; set; }
        public List<CatalogItem> Items;

        public int NumItems
        {
            get
            {
                return Items.Count;
            }
        }

        public Catalog(string name)
        {
            Name = name;
            Items = new List<CatalogItem>();
        }

        public void AddItem(CatalogItem item)
        {
            Items.Add(item);
        }

        public List<CatalogItem> Search(string searchTerm)
        {
            List<CatalogItem> searchResults = new List<CatalogItem>();

            foreach (CatalogItem item in Items)
            {
                if (item.Search(searchTerm))
                {
                    searchResults.Add(item);
                }
            }
            return searchResults;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Library name: ");
            sb.Append(Name);
            sb.Append("\n");
            sb.Append("Total items: ");
            sb.Append(NumItems);
            sb.Append("\n");

            foreach (CatalogItem c in Items)
            {
                sb.Append(c);
                sb.Append("\n");
            }

            return sb.ToString();
        }
    }
}
