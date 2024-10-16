﻿namespace XX_Alexandria.Models
{
    internal class CatalogItem : ISearchable
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }

        public CatalogItem(string id, string title, string year)
        {
            ID = id;
            Title = title;
            Year = year;
        }

        public override string ToString()
        {
            return $"CatalogItem {{ ID: {ID} Title: {Title} Year: {Year} }}";
        }

        public virtual bool Search(string searchTerm)
        {
            //Search item terms
            return Title.ToLower().Contains(searchTerm.ToLower()) ||
               Year.ToLower().Contains(searchTerm.ToLower());

        }
    }

}
