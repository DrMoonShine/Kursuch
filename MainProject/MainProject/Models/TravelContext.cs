using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MainProject.Models
{
    public class TravelContext : DbContext
    {
        //каждый DbSet<...> - соотноситься с каждой таблицей в БД
        public DbSet<User> Users { get; set; }
        public DbSet<Timetable> TimeTables{ get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<Bunch> Bunchs { get; set; }

        public TravelContext(DbContextOptions<TravelContext> options)
            : base(options)
        {
            Database.EnsureCreated(); //если БД нет, то автоматически создат её 
        }
    }
}
