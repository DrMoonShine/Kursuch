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
        public int UserRouteID { get; set; }//ссылка на связную модель маршруты
        public UserRoute Route { get; set; }
        // public List<UserRoute> uRoutes { get; set; } //список маршрутов
        //public IEnumerable<string> RoutesId { get; set; }
    }
}
