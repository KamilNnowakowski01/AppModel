using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static System.Reflection.Metadata.BlobBuilder;

namespace AppModel.Models
{
    public class Book
    {

        public Book()
        {
            BookAuthors = new HashSet<Book_Author>();
        }

        [Key]
        public int BookId { get; set; }

        [Required]
        public string Title { get; set; }

        public string Genre { get; set; }

        [Required]
        public int PublicationYear { get; set; }

        public int? PublisherId { get; set; }

        [ForeignKey("PublisherId")]
        public virtual Publisher? Publisher { get; set; }

        public virtual ICollection<Book_Author> BookAuthors { get; set; }
    }
}
