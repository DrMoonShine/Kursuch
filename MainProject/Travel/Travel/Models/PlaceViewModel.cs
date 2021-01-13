//класс для сортировки по фильтрам и поиску
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
        public SelectList RStatus { get; set; } //список статусов
        public SelectList RTyps { get; set; } //список типов
        public int Cost { get; set; }//максимальная стоимость/цена
        public string cStatus { get; set; } //объект содержащий выбранный стутус
        public string cType { get; set; } //объект содержащий выбранный тип
        public string PlaceCitys{ get; set; } //объект содержаший выбранный город
        public string SearchString { get; set; } //строка, которую ввел пользователь
    }
}
