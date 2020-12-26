using Microsoft.EntityFrameworkCore;
using ModelsLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DBContext
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public virtual DbSet<Product> Product { get; private set; }
        public virtual DbSet<Orders> Orders { get; private set; }
        public virtual DbSet<OrderProduct> OrderProduct { get; private set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            }

            //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            //{
            //    Console.WriteLine("test");
            //}

        }
}
