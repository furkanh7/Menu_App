using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Menu_App.Entities;

namespace Menu_App.Context
{
    public class MenuContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=FURKAN;initial catalog=Menu_AppDb; integrated security=true");
        }

        public DbSet<Product> Products { get; set; }
        
        public DbSet<Chef> Chefs { get; set; }
        public DbSet<Booking> Bookings { get; set; }

    }
}
