using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MainProject.Models
{
    public class Timetable
    {
        public int Id { get; set; }
        public int RouteID { get; set; } //ссылка на связанную модель Route
        public int UserID { get; set; } //ссылка на связнную модель User
    }
}
