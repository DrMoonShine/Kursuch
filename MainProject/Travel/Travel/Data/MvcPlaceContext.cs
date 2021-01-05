using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Travel.Models;

namespace Travel.Data
{
    public class MvcPlaceContext : DbContext
    {
        public MvcPlaceContext(DbContextOptions<MvcPlaceContext> options)
            : base(options)
        {
        }

        public DbSet<Place> Movie{ get; set; }
        public DbSet<Route> Route { get; set; }
        public DbSet<Bunch> Bunch { get; set; }
        public DbSet<TimeTable> TimeTable { get; set; }
        public DbSet<User> User { get; set; }
    }
}
