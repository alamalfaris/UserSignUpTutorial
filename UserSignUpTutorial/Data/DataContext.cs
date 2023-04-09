using Microsoft.EntityFrameworkCore;
using UserSignUpTutorial.Models;

namespace UserSignUpTutorial.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder
                .UseSqlServer("Server=ALAMALFARIS;Database=usersignupDB;Trusted_Connection=true");
        }

        public DbSet<User> Users => Set<User>();
    }
}
