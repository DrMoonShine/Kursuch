using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Travel.Models
{
    public class Bunch
    {
        public int Id { get; set; }
        public int PlaceID { get; set; } //ссылка на связную модель места
        public  Place Place { get; set; }
        public int RouteID { get; set; }//ссылка на связную модель маршруты
        public Route Route { get; set; }
    }
}
