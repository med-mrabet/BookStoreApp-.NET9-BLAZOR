using System.ComponentModel.DataAnnotations;

namespace BookStoreApp.API.Dtos.Author
{
    public class CreateAuthorDto
    {
        [Required]
        public string FirstName { get; set; } =string.Empty;
        [Required]
        public string LastName {  get; set; } =string.Empty;

        public string Bio {  get; set; } = string.Empty;

    }
}
