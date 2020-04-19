using HelpMeNeighbour.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace HelpMeNeighbour.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        public virtual DbSet<Ad> Ad { get; set; }
        public virtual DbSet<Review> Review { get; set; }
        public virtual DbSet<Message> Message { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<AdCategory> AdCategorie { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdCategory>()
                .HasKey(ac => new { ac.IdAd, ac.IdCategory });

            modelBuilder.Entity<AdCategory>()
                .HasOne(ac => ac.Ad)
                .WithMany(a => a.AdCategories)
                .HasForeignKey(ac => ac.IdAd);

            modelBuilder.Entity<AdCategory>()
                .HasOne(ac => ac.Category)
                .WithMany(c => c.AdCategories)
                .HasForeignKey(ac => ac.IdCategory);

            modelBuilder.Entity<Review>()
                .HasOne(r => r.Reviewer)
                .WithMany(u => u.CreatedReviews)
                .HasForeignKey(r => r.IdReviewer);

            modelBuilder.Entity<Review>()
                .HasOne(r => r.Reviewed)
                .WithMany(u => u.Reviews)
                .HasForeignKey(r => r.IdReviewed);

            modelBuilder.Entity<User>()
                .HasIndex(b => b.Email)
                .IsUnique();
        }
    }
}
