using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.Data.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime PublishedDate { get; set; }
        public decimal Price { get; set; }

        public string ISBN { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;
        public int AuthorId { get; set; }
        // Navigation property
        public Author? Author { get; set; }
    }
}
