using Microsoft.EntityFrameworkCore;

namespace bets_on_api.Models
{
    public static class AppModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Sports" },
                new Category { Id = 2, Name = "TV & Entertainment" },
                new Category { Id = 3, Name = "Other" }
            );

            modelBuilder.Entity<Challenge>().HasData(
                new Challenge { Id = 1, CategoryId = 1, Description = "Grunge Skater Jeans", Title = "AWMGSJ", Amount = 68, IsAvailable = true },
                new Challenge { Id = 2, CategoryId = 1, Description = "Polo Shirt", Title = "AWMPS", Amount = 35, IsAvailable = true },
                new Challenge { Id = 3, CategoryId = 1, Description = "Skater Graphic T-Shirt", Title = "AWMSGT", Amount = 33, IsAvailable = true },
                new Challenge { Id = 4, CategoryId = 1, Description = "Slicker Jacket", Title = "AWMSJ", Amount = 125, IsAvailable = true },
                new Challenge { Id = 5, CategoryId = 1, Description = "Thermal Fleece Jacket", Title = "AWMTFJ", Amount = 60, IsAvailable = true },
                new Challenge { Id = 6, CategoryId = 1, Description = "Unisex Thermal Vest", Title = "AWMUTV", Amount = 95, IsAvailable = true },
                new Challenge { Id = 7, CategoryId = 1, Description = "V-Neck Pullover", Title = "AWMVNP", Amount = 65, IsAvailable = true },
                new Challenge { Id = 8, CategoryId = 1, Description = "V-Neck Sweater", Title = "AWMVNS", Amount = 65, IsAvailable = true },
                new Challenge { Id = 9, CategoryId = 1, Description = "V-Neck T-Shirt", Title = "AWMVNT", Amount = 17, IsAvailable = true },
                new Challenge { Id = 10, CategoryId = 2, Description = "Bamboo Thermal Ski Coat", Title = "AWWBTSC", Amount = 99, IsAvailable = true },
                new Challenge { Id = 11, CategoryId = 2, Description = "Cross-Back Training Tank", Title = "AWWCTT", Amount = 0, IsAvailable = true },
                new Challenge { Id = 12, CategoryId = 2, Description = "Grunge Skater Jeans", Title = "AWWGSJ", Amount = 68, IsAvailable = true },
                new Challenge { Id = 13, CategoryId = 2, Description = "Slicker Jacket", Title = "AWWSJ", Amount = 125, IsAvailable = true },
                new Challenge { Id = 14, CategoryId = 2, Description = "Stretchy Dance Pants", Title = "AWWSDP", Amount = 55, IsAvailable = true },
                new Challenge { Id = 15, CategoryId = 2, Description = "Ultra-Soft Tank Top", Title = "AWWUTT", Amount = 22, IsAvailable = true },
                new Challenge { Id = 16, CategoryId = 2, Description = "Unisex Thermal Vest", Title = "AWWUTV", Amount = 95, IsAvailable = true },
                new Challenge { Id = 17, CategoryId = 2, Description = "V-Next T-Shirt", Title = "AWWVNT", Amount = 17, IsAvailable = true },
                new Challenge { Id = 18, CategoryId = 3, Description = "Blueberry Mineral Water", Title = "MWB", Amount = 2.8M, IsAvailable = true },
                new Challenge { Id = 19, CategoryId = 3, Description = "Lemon-Lime Mineral Water", Title = "MWLL", Amount = 2.8M, IsAvailable = true },
                new Challenge { Id = 20, CategoryId = 3, Description = "Orange Mineral Water", Title = "MWO", Amount = 2.8M, IsAvailable = true },
                new Challenge { Id = 21, CategoryId = 3, Description = "Peach Mineral Water", Title = "MWP", Amount = 2.8M, IsAvailable = true },
                new Challenge { Id = 22, CategoryId = 3, Description = "Raspberry Mineral Water", Title = "MWR", Amount = 2.8M, IsAvailable = true },
                new Challenge { Id = 23, CategoryId = 3, Description = "Strawberry Mineral Water", Title = "MWS", Amount = 2.8M, IsAvailable = true }
            );

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "Adam", Email = "adam@example.com" },
                new User { Id = 2, Name = "Barbara", Email = "barbara@example.com" }
            );
        }
    }
}
