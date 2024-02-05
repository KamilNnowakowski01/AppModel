using AppModel.Models;

namespace AppModel.ViewModels
{
    public class BookWithListCollectionVM
    {
        public Book Book { get; set; }
        public int[] AuthorsIds { get; set; }
        public ICollection<Author> Authors { get; set; }
        public ICollection<Publisher> Publishers { get; set; }
        public BookWithListCollectionVM()
        {
            Authors = new HashSet<Author>();
            Publishers = new HashSet<Publisher>();
        }
        
    }
}
