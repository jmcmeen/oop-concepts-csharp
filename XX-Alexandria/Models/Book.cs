using XX_Alexandria.Models;

namespace XX_Alexandria.Models
{
    internal class Book : CatalogItem
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
    }
}
