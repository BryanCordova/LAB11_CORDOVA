using LAB11_CORDOVA.Models;
using Microsoft.EntityFrameworkCore;

namespace LAB11_CORDOVA.Data
{
    public class MyDbContext : DbContext
    {
        

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Detail> Details { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }
    }
}
