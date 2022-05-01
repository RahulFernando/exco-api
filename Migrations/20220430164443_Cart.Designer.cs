﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using exco_api.Models;

namespace exco_api.Migrations
{
    [DbContext(typeof(ExcoDbContext))]
    [Migration("20220430164443_Cart")]
    partial class Cart
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("exco_api.Models.Cart", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("userid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("userid");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("exco_api.Models.Item", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("Cartid")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.Property<int>("type")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Cartid");

                    b.ToTable("Items");
                });

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

            modelBuilder.Entity("exco_api.Models.Cart", b =>
                {
                    b.HasOne("exco_api.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("exco_api.Models.Item", b =>
                {
                    b.HasOne("exco_api.Models.Cart", null)
                        .WithMany("items")
                        .HasForeignKey("Cartid");
                });

            modelBuilder.Entity("exco_api.Models.Cart", b =>
                {
                    b.Navigation("items");
                });
#pragma warning restore 612, 618
        }
    }
}