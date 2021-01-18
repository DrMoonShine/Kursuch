using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Travel.Models
{
    public class RouteViewModel
    {
      public List<UserRoute> AllUserRoutes { get; set; } //список путей
      public List<Bunch> AllBunch { get; set; } //список Связок
      public List<Place> AllPlaces { get; set; } //список Мест
       
    }
}
