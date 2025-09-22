﻿namespace BookStoreApp.API.Dtos.Book
{
    public class UpdateBookDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime PublishedDate { get; set; }
        public decimal Price { get; set; }

        public string ISBN { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;
    }
}
