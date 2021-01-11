using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Travel.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public int PlaceID { get; set; } //ссылка на связную модель места
        public Place Place { get; set; }
        public string RPhoto { get; set; }
        
    }
}
