using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Travel.Models
{
    public class TimeTable
    {
        public int Id { get; set; }
        public int UserID { get; set; } //ссылка на связную модель места
        public User User { get; set; }
        public int RouteID { get; set; }//ссылка на связную модель маршруты
        public Route Route { get; set; }
    }
}
