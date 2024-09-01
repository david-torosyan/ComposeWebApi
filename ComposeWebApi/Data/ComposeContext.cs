using Microsoft.EntityFrameworkCore;

namespace ComposeWebApi.Data
{
    public class ComposeContext : DbContext
    {
        public ComposeContext(DbContextOptions<ComposeContext> option) : base(option)
        {
        }

        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Person>().HasData(
                new Person { Id = 1, Name = "Robert" },
                new Person { Id = 2, Name = "Margaret" });
        }
    }
}
