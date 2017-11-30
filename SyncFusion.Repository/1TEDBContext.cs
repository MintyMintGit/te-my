using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using _1TE_MY.Models;
using _1TE_MY.Models.Models;

namespace _1TE_MY.Repository
{
    public class _1TEDBContext : DbContext
    {
        public _1TEDBContext(DbContextOptions<_1TEDBContext> options) : base(options)
        {
        }

        public DbSet<Employees> Employees { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Shippers> Shippers { get; set; }
        public DbSet<Products> Products { get; set; }

        public DbSet<Contact> Contact { get; set; }
        public DbSet<UDC_Details> UDC_Detail { get; set; }
        public DbSet<UDC_Master> UDC_Master { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Registration> Registration { get; set; }
		public DbSet<Address> Address { get; set; }
		
		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Orders>().HasOne(e => e.OrderDetails).WithOne().HasForeignKey<OrderDetails>();

        }


    }
}
