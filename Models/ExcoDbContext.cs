using Microsoft.EntityFrameworkCore;

namespace exco_api.Models
{
    public class ExcoDbContext : DbContext
    {
        public ExcoDbContext(DbContextOptions<ExcoDbContext> options) : base(options)
        {

        }

        public DbSet<Lending> Lendings { get; set; }
    }
}