using InAndOut.Models;
using Microsoft.EntityFrameworkCore;

namespace InAndOut.Data
{
    public class AplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<AplicationDbContext> options ) : base(options)
        {

        }


        public DbSet<Item> Items{ get; set; }
    }
}
