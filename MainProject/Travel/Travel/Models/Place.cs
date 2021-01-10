using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Travel.Models
{
    public class Place
    {
        public int Id { get; set; } 
        public string City { get; set; }
        public string Address { get; set; }
        public int Cost { get; set; }
        public int Rate { get; set; }
        public string Time { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public string ReviewPlace { get; set; }
    

}
}