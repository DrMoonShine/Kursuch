using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Travel.Models;

namespace Travel.Data
{
    public class TravelContext : IdentityDbContext<IdentityUser>
    {
        public TravelContext(DbContextOptions<TravelContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            
        }
        public DbSet<Place> Movie { get; set; }
        public DbSet<Route> Route { get; set; }
        public DbSet<Bunch> Bunch { get; set; }
        public DbSet<TimeTable> TimeTable { get; set; }
        public DbSet<Photo> Photo { get; set; }

    }
}
