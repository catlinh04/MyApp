using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyApp.Infrastructure.Data.Seeding
{
    public static class ApplicationDbContextSeed
    {
        public static async Task SeedAsync(ApplicationDbContext context)
        {
            using var transaction = await context.Database.BeginTransactionAsync();

            try
            {
                // Tắt khóa ngoại để tránh lỗi
                await context.Database.ExecuteSqlRawAsync("EXEC sp_MSforeachtable @command1 = 'ALTER TABLE ? NOCHECK CONSTRAINT ALL'");

                // Xóa tất cả dữ liệu
                await context.Database.ExecuteSqlRawAsync("DELETE FROM OrderItems");
                await context.Database.ExecuteSqlRawAsync("DELETE FROM Orders");
                await context.Database.ExecuteSqlRawAsync("DELETE FROM Items");

                // Bật lại khóa ngoại
                await context.Database.ExecuteSqlRawAsync("EXEC sp_MSforeachtable @command1 = 'ALTER TABLE ? CHECK CONSTRAINT ALL'");

                // Seed Items
                await context.Items.AddRangeAsync(ItemSeed.Data);
                Console.WriteLine("Items seeded.");

                // Seed Orders
                await context.Orders.AddRangeAsync(OrderSeed.Data);
                Console.WriteLine("Orders seeded.");

                // Seed OrderItems
                await context.OrderItems.AddRangeAsync(OrderItemSeed.Data);
                Console.WriteLine("OrderItems seeded.");

                await context.SaveChangesAsync();
                await transaction.CommitAsync();
                Console.WriteLine("Seeding completed successfully.");
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                Console.WriteLine($"Error seeding database: {ex.Message}");
            }
        }
    }
}