using IMSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace IMSystem.Data
{
    public class IMSContext : DbContext
    {
        public IMSContext(DbContextOptions<IMSContext>options):base(options)
        {

        }
        public DbSet<Product> Products {get; set;}
        
    }
}