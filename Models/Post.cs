using System.ComponentModel.DataAnnotations;

namespace SimpleBloggingAPI.Models
{
    public class Post
    {
        public int Id { get; set; }
        [Required]
        public required string Title { get; set; }
        [Required]
        public required string Content { get; set; }
        [Required]
        public required string Category { get; set; }
        public required List<string> Tags { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
