using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MainProject.Models
{
    public class Place
    {
        public int Id { get; set; }
        public string City { get; set; } //город в котором находится место
        public string Address { get; set; } 
        public string Cost { get; set; }
        public int Rate { get; set; } //общий рейтинг места 
        public string Time { get; set; } //время потораченное на потраченное
        public string Status { get; set; } //статус - 18+, можно с детьми
        public string Type { get; set; } //тип - парк, кафе и тп
        public string Website { get; set; } //сайт места, если есть
        public string ReviewPlace { get; set; } //отзывы 
    }
}
