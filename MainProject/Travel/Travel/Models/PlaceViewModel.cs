using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Travel.Models
{
    public class PlaceViewModel
    {
        public List<Place> Places { get; set; } //список мест
        public SelectList Citys { get; set; } //список городов
        public string PlaceCitys{ get; set; } //объект содержаший выбранный город
        public string SearchString { get; set; } //строка, которую ввел пользователь
    }
}
