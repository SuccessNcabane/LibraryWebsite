

namespace backend.Models
{
    public class Book
    {
        public int Id{ get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public bool isAvailable { get; set; } = true;
        public string PublishedYear { get; set; } 
    }
}
