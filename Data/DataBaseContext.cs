using interviewTest.Models;
using Microsoft.EntityFrameworkCore;
namespace Data
{
    public class DataBaseContext : DbContext
    {
        protected override void OnConfiguring
       (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "AuthorDb");
        }
        public DbSet<InventoryManagment> InventoryManagments { get; set; }
    }
}