using Microsoft.EntityFrameworkCore;
using ProjectLibrary.Classes;

namespace ProjectLibrary.Data
{
    public class ApplicationDBContext : DbContext
    {
       
    public DbSet<Book> Books { get; set; }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options)
        { 
        }
    }
}