using Microsoft.EntityFrameworkCore;

namespace Notes.Data
{  
        public class ApplicationContext : DbContext
        {
            public DbSet<Note> Notes { get; set; }
            public ApplicationContext()
            {
                Database.EnsureCreated();
            }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=notedb;Username=postgres;Password=miha5");
            }
        }    
}
