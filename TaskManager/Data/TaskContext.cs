using Microsoft.EntityFrameworkCore;
using TaskManager.Models;

namespace TaskManager.Data
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<TaskItem> Tasks { get; set;}

        public DbSet<User> Users { get; set;}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaskItem>()
                .HasOne(o => o.Assignee)          // Each Order has one Person
                .WithMany(p => p.Tasks)         // One Person has many Orders
                .HasForeignKey(o => o.AssigneeId); // Order has the FK

            modelBuilder.Entity<User>()
                .HasOne(a => a.Address)
                .WithOne(b => b.User)
                .HasForeignKey<Address>(c => c.UserId);

            base.OnModelCreating(modelBuilder);
        }

    }
}
