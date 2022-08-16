using System;
using System.ComponentModel.DataAnnotations;
namespace BookCatalog.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Author { get; set; }

    }
}

