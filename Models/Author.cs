using System.ComponentModel.DataAnnotations;

namespace AppModel.Models
{
    public class Author
    {
        public Author()
        {
            BookAuthors = new HashSet<Book_Author>();
        }

        [Key]
        public int AuthorId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string CountryOfOrigin { get; set; }

        public virtual ICollection<Book_Author> BookAuthors { get; set; }
    }
}
