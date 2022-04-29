using Microsoft.EntityFrameworkCore;

namespace exco_api.Models
{
    public class ExcoDbContext : DbContext
    {
        public ExcoDbContext(DbContextOptions<ExcoDbContext> options) : base(options)
        {

        }

        public DbSet<Lending> Lendings { get; set; }
        public DbSet<Reference> References { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Lending>().HasData(
                new Lending
                {
                    id = 1,
                    name = "1984 by george orwell",
                    img = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1327144697l/3744438.jpg"
                },

                new Lending
                {
                    id = 2,
                    name = "The Lord of the Rings by J.R.R. Tolkien",
                    img = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1566425108l/33.jpg"
                }
            );

            modelBuilder.Entity<Reference>().HasData(
                new Reference
                {
                    id = 1,
                    name = "Publication Manual of the American Psychological Association",
                    img = "https://i.pinimg.com/originals/a7/41/83/a741836e774ae812b4fd45f9bcc14dbe.png"
                },
                new Reference
                {
                    id = 2,
                    name = "The Secrets of Character",
                    img = "https://images-na.ssl-images-amazon.com/images/I/71pAQQsWJFL.jpg"
                }
            );
        }
    }
}