using blinkApi.Models;
using Microsoft.EntityFrameworkCore;

namespace blinkApi.Contexts
{
    public class BlinkDB: DbContext
    {
        public BlinkDB(DbContextOptions options) : base(options)
        { }
        
        public DbSet<User> users { get; set; }
        public DbSet<Posts> posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity => { entity.ToTable("users"); });
            modelBuilder.Entity<Posts>(entity =>
            {
                entity.ToTable("post");
                entity.HasKey(e => e.id);
                entity.HasOne(p => p.user)
                    .WithMany(u => u.posts)
                    .HasForeignKey(p => p.user_id);
            });
        }
    }
}