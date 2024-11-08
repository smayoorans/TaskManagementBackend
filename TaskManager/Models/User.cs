using System.ComponentModel.DataAnnotations;

namespace TaskManager.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string? Email { get; set; }

        public string? Password { get; set; }

        public string? Phone { get; set; }

        public ICollection<TaskItem> Tasks { get; set; } = new List<TaskItem>();

        public Address? Address { get; set; }

        public Role Role { get; set; }

    }
}
