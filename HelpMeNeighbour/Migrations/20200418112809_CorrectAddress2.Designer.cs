﻿// <auto-generated />
using System;
using HelpMeNeighbour.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HelpMeNeighbour.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200418112809_CorrectAddress2")]
    partial class CorrectAddress2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("HelpMeNeighbour.Entities.Ad", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnName("id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Address")
                        .HasColumnName("address")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Bonus")
                        .HasColumnName("bonus")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnName("creation_date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnName("description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Picture")
                        .HasColumnName("picture")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Title")
                        .HasColumnName("title")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("ad");
                });

            modelBuilder.Entity("HelpMeNeighbour.Entities.AdCategory", b =>
                {
                    b.Property<string>("IdAd")
                        .HasColumnName("id_ad")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("IdCategory")
                        .HasColumnName("id_category")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("IdAd", "IdCategory");

                    b.HasIndex("IdCategory");

                    b.ToTable("ad_category");
                });

            modelBuilder.Entity("HelpMeNeighbour.Entities.Category", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnName("id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Description")
                        .HasColumnName("description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("category");
                });

            modelBuilder.Entity("HelpMeNeighbour.Entities.Message", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnName("id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("AdId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("AuthorId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Content")
                        .HasColumnName("content")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("SendedDate")
                        .HasColumnName("sended_date")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("AdId");

                    b.HasIndex("AuthorId");

                    b.ToTable("message");
                });

            modelBuilder.Entity("HelpMeNeighbour.Entities.Review", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnName("id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Comment")
                        .HasColumnName("comment")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Grade")
                        .HasColumnName("grade")
                        .HasColumnType("int");

                    b.Property<string>("IdReviewed")
                        .HasColumnName("id_reviewed")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("IdReviewer")
                        .HasColumnName("id_reviewer")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("IdReviewed");

                    b.HasIndex("IdReviewer");

                    b.ToTable("review");
                });

            modelBuilder.Entity("HelpMeNeighbour.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnName("id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Address")
                        .HasColumnName("address")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("City")
                        .HasColumnName("city")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Email")
                        .HasColumnName("email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("FirstName")
                        .HasColumnName("firstname")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("LastName")
                        .HasColumnName("lastname")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Password")
                        .HasColumnName("password")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Salt")
                        .HasColumnName("salt")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("State")
                        .HasColumnName("state")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ZipCode")
                        .HasColumnName("zipcode")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("user");
                });

            modelBuilder.Entity("HelpMeNeighbour.Entities.Ad", b =>
                {
                    b.HasOne("HelpMeNeighbour.Entities.User", "User")
                        .WithMany("Ads")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("HelpMeNeighbour.Entities.AdCategory", b =>
                {
                    b.HasOne("HelpMeNeighbour.Entities.Ad", "Ad")
                        .WithMany("AdCategories")
                        .HasForeignKey("IdAd")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HelpMeNeighbour.Entities.Category", "Category")
                        .WithMany("AdCategories")
                        .HasForeignKey("IdCategory")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HelpMeNeighbour.Entities.Message", b =>
                {
                    b.HasOne("HelpMeNeighbour.Entities.Ad", "Ad")
                        .WithMany("Messages")
                        .HasForeignKey("AdId");

                    b.HasOne("HelpMeNeighbour.Entities.User", "Author")
                        .WithMany("Messages")
                        .HasForeignKey("AuthorId");
                });

            modelBuilder.Entity("HelpMeNeighbour.Entities.Review", b =>
                {
                    b.HasOne("HelpMeNeighbour.Entities.User", "Reviewed")
                        .WithMany("Reviews")
                        .HasForeignKey("IdReviewed");

                    b.HasOne("HelpMeNeighbour.Entities.User", "Reviewer")
                        .WithMany("CreatedReviews")
                        .HasForeignKey("IdReviewer");
                });
#pragma warning restore 612, 618
        }
    }
}
