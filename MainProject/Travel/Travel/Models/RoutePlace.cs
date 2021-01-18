using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Travel.Models
{
    public class RoutePlace
    {
      
        public int PlaceID { get; set; }
        //public int RouteID { get; set; }
        public List<UserRoute> uRoutes { get; set; } //список маршрутов
        //public IEnumerable<string> RoutesName { get; set; }
    }
}
