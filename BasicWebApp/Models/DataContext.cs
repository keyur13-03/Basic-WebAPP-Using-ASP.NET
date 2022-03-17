﻿using Microsoft.EntityFrameworkCore;

namespace BasicWebApp.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        { 
            Database.EnsureCreated();
        }
        public DbSet<Product> Products { get; set; }
        
    }
}
