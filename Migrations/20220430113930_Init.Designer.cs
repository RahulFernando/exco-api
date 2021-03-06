// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using exco_api.Models;

namespace exco_api.Migrations
{
    [DbContext(typeof(ExcoDbContext))]
    [Migration("20220430113930_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("exco_api.Models.Lending", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("img")
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Lendings");

                    b.HasData(
                        new
                        {
                            id = 1,
                            img = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1327144697l/3744438.jpg",
                            name = "1984 by george orwell"
                        },
                        new
                        {
                            id = 2,
                            img = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1566425108l/33.jpg",
                            name = "The Lord of the Rings by J.R.R. Tolkien"
                        });
                });

            modelBuilder.Entity("exco_api.Models.Reference", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("img")
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("References");

                    b.HasData(
                        new
                        {
                            id = 1,
                            img = "https://i.pinimg.com/originals/a7/41/83/a741836e774ae812b4fd45f9bcc14dbe.png",
                            name = "Publication Manual of the American Psychological Association"
                        },
                        new
                        {
                            id = 2,
                            img = "https://images-na.ssl-images-amazon.com/images/I/71pAQQsWJFL.jpg",
                            name = "The Secrets of Character"
                        });
                });

            modelBuilder.Entity("exco_api.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .HasColumnType("text");

                    b.Property<string>("password")
                        .HasColumnType("text");

                    b.Property<string>("user_name")
                        .HasColumnType("text");

                    b.Property<int>("user_type")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            id = 1,
                            email = "urbanrunes@gmail.com",
                            password = "$2a$10$AvnYqhBMLzlQlvdAF/SB3u/sRnv12vkUwbJCc/xM0zY.34QPJKlmK",
                            user_name = "Mason",
                            user_type = 0
                        },
                        new
                        {
                            id = 2,
                            email = "urbanrunes@gmail.com",
                            password = "$2a$10$9QtT54SirItxnsRlb9q6HeNYKQSqdJ6AGBlmAdkTbZzS/EX1m2dBK",
                            user_name = "Loki",
                            user_type = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
