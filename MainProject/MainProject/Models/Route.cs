using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MainProject.Models
{
    public class Route
    {
        public int Id { get; set; }
        public string RateRoute { get; set; } //рейинг маршрута
        public string DateAdd{ get; set; } //дата добавления маршрута
        public string ReviewRoute { get; set; } //отзывы о маршруте
    }
}
