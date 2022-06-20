using System;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Data
{
	
        public class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
            public DbSet<Product> Products { get; set; }
            public DbSet<Slider> Sliders { get; set; }
    }
}

