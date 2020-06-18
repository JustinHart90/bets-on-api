using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_raw.Models
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Challenge>().HasMany(c => c.Bets).WithOne(a => a.Category).HasForeignKey(a => a.CategoryId);

            modelBuilder.Entity<Category>().HasMany(c => c.Bets);

            modelBuilder.Entity<Bet>().HasOne(b => b.Challenge);
            modelBuilder.Entity<Bet>().HasOne(b => b.Category);
            modelBuilder.Entity<Bet>().HasOne(b => b.User);

            modelBuilder.Entity<User>().HasMany(c => c.Bets);
            modelBuilder.Entity<User>().HasMany(c => c.Challenges);

            modelBuilder.Seed();
        }

        public DbSet<Bet> Bets { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Challenge> Challenges { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
