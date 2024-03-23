namespace XX_Alexandria.Models
{
    internal class Book : CatalogItem, ISearchable
    {
        public string Author { get; set; }
        public string ISBN { get; set; }
        public BookType BookType { get; set; }
        public Book(string id, string title, string year, string author, string iSBN, BookType bookType) : base(id, title, year)
        {
            Author = author;
            ISBN = iSBN;
            BookType = bookType;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Book {{ Author: {Author} ISBN: {ISBN} Type: {BookType} }}";
        }

        public override bool Search(string searchTerm)
        {
            //Search item terms
            return Title.ToLower().Contains(searchTerm.ToLower()) ||
               Year.ToLower().Contains(searchTerm.ToLower()) ||
               Author.ToLower().Contains(searchTerm.ToLower()) ||
               ISBN.ToLower().Contains(searchTerm.ToLower());

        }
    }
}
