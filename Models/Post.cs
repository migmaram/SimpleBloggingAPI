using System.ComponentModel.DataAnnotations;

namespace SimpleBloggingAPI.Models
{
    public class Post
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public Category? Category { get; set; }
        public int CategoryId { get; set; }
        [Required]
        public List<Tag> Tags { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

    }
}
