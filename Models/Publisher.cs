using System.ComponentModel.DataAnnotations;

namespace AppModel.Models
{
    public class Publisher
    {
        public Publisher()
        {
            Books = new HashSet<Book>();
        }

        [Key]
        public int PublisherId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public int YearFounded { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }

}
