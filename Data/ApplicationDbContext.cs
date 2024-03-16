using Microsoft.EntityFrameworkCore;
using MVCSampleAPP.Models;

namespace MVCSampleAPP.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }

    }
}
