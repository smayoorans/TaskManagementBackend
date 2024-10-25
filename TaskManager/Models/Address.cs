using System.ComponentModel.DataAnnotations;

namespace TaskManager.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public required string AdddressLine1 { get; set; }
        
        public string? AdddressLine2 { get; set; }

        public string? City { get; set; }

        public int? UserId { get; set; }

        public User? User { get; set; }

    }
}
