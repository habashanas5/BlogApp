using System.ComponentModel.DataAnnotations;

namespace BlogApp.Models
{
    public class Blog
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Title is required.")]
        [StringLength(100, ErrorMessage = "The Title must be less than 100 characters.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "The Content is required.")]
        public string Content { get; set; }

        [Required(ErrorMessage = "The Author is required.")]
        [StringLength(50, ErrorMessage = "The Author must be less than 50 characters.")]
        public string Author { get; set; }

        [Required(ErrorMessage = "The Date is required.")]
        public DateTime Date { get; set; }

        public string Category { get; set; }
    }
}
