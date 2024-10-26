using System.ComponentModel.DataAnnotations;

namespace TaskManager.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public required string AddressLine1 { get; set; }
        
        public string? AddressLine2 { get; set; }

        public string? City { get; set; }

        public int? UserId { get; set; }

        public User? User { get; set; }

    }
}
