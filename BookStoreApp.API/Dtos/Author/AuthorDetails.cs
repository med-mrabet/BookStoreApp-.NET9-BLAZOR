namespace BookStoreApp.API.Dtos.Author
{
    public class AuthorDetailsDto
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string LastName { get; set; } = string.Empty;
        public string Bio {  get; set; } = string.Empty ;

        public DateTime DateOfBirth { get; set; }


    }
}
