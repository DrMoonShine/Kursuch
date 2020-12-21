using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MainProject.Models
{
    public class Bunch
    {
        public string Id { get; set; }
        public string RouteID { get; set; } //связь с моелью Route
        public string PlaceID { get; set; } //связь с моделью Place

    }
}
