using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Travel.Data;
using Travel.Models;

namespace Travel.Controllers
{
    public class RouteController : Controller
    {
        private readonly TravelContext _cont;

        public RouteController(TravelContext cont)
        {
            _cont = cont;
        }
        public async Task<IActionResult> IndexRoute()
        {
            return View(await _cont.UserRoute.ToListAsync());
        }
    }
}
