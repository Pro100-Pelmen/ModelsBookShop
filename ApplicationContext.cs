using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;
using System.Windows.Controls;

namespace ModelsBookShop
{
    internal class ApplicationContext : DbContext
    {

        public DbSet<Buyer> Buyers { get; set; } = null!;
        public DbSet<Employee> Employees { get; set; } = null!;
        public DbSet<Role> Roles { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<CompoundOrder> CompoundOrders { get; set; } = null!;
        public DbSet<Book> Books { get; set; } = null!;
        public DbSet<Author> Authors { get; set; } = null!;

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;user=root;password=123456789;database=library", new MySqlServerVersion(new Version(8, 0, 41)));
        }

      
    }    
}
