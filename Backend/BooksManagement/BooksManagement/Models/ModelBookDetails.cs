using System.ComponentModel.DataAnnotations;

namespace BooksManagement.Models
{
    public class ModelBookDetails
    {
        public int? Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(100)]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Author is required")]
        [StringLength(100)]
        public string? Author { get; set; }

        [Required(ErrorMessage = "ISBN is required")]
        [StringLength(50)]
        public string? ISBN { get; set; }

        public DateTime? PublicationDate { get; set; }
    }
}
