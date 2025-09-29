﻿using Microsoft.AspNetCore.Identity;

namespace BookStoreApp.Data.Models
{
    public class ApiUser : IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = String.Empty;
    }
}
