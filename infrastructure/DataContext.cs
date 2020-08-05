using core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace infrastructure
{
    public  class DataContext:DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) :base(options)
        {
        }
        public DbSet<Categorys> Categorys { get; set; }

        public DbSet<Products> Products { get; set; }
        public DbSet<Users> Users { get; set; }

        //protected override  void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //}
      
    }
}
