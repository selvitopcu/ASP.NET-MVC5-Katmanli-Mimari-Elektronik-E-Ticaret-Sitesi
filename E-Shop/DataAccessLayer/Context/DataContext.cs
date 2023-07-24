using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DataAccessLayer.Context
{
    public class DataContext:DbContext
    {
        /*
         Entity framework Core'da cs vermek için bu kod bloğu kuullanılır.
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
             optionsBuilder.UseSqlServer(@"Data Source=SELVITOPCU\SQLEXPRESS;Initial Catalog=KitapCafe;Integrated Security=True;TrustServerCertificate=True");

         }Bizim projemiz core olmadığı için aşağıdakı kod bloğunu yazdık.
         */
        public DataContext() : base("Data Source=SELVITOPCU\\SQLEXPRESS; Initial Catalog = E-Tica; Integrated Security=true;") { }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }

    }
}
