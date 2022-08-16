using Microsoft.EntityFrameworkCore;
using LMS.web.Models;

namespace LMS.web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Author> Authors { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<LMS.web.Models.Author> Author { get; set; }
    }
}
