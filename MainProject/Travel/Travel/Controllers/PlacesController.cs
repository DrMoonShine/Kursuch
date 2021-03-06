﻿using System;
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
    public class PlacesController : Controller
    {

        private readonly TravelContext _context;

        public PlacesController(TravelContext context)
        {
            _context = context;
        }
        //Метотд GET используется по умолчанию, поэтому [HttpGet] можно не писать
        // GET: Places
        
        public async Task<IActionResult> Index(string cTyps, string cStatus, string placeCitys, string searchString)
        {
            IQueryable<string> placeQuery = from p in _context.Place
                                            orderby p.City
                                            select p.City;
            IQueryable<string> statusQuery = from st in _context.Place
                                             orderby st.Status
                                             select st.Status;
            IQueryable<string> typeQuery = from t in _context.Place
                                           orderby t.Type
                                           select t.Type;

            var places = from p in _context.Place
                         select p;

            if (!string.IsNullOrEmpty(searchString)) // Если не null
            {
                places = places.Where(s => s.NamePlace.Contains(searchString)); //Название введенное пользователем 
            }

            if (!string.IsNullOrEmpty(placeCitys)) //Если не null
            {
                places = places.Where(x => x.City == placeCitys); //Фильтр города
            }
            if (!string.IsNullOrEmpty(cStatus)) //Если не null
            {
                places = places.Where(y => y.Status == cStatus); //Фильтр города
            }
            if (!string.IsNullOrEmpty(cTyps)) //Если не null
            {
                places = places.Where(z => z.Type == cTyps); //Фильтр города
            }
            //передача полученныех и отсортированных данных
            var placeVM = new PlaceViewModel
            {
                RTyps = new SelectList(await typeQuery.Distinct().ToListAsync()),
                RStatus = new SelectList(await statusQuery.Distinct().ToListAsync()),
                Citys = new SelectList(await placeQuery.Distinct().ToListAsync()),
                Places = await places.ToListAsync()

            };

            return View(placeVM);
        }

        // GET: Places/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var place = await _context.Place
                .FirstOrDefaultAsync(m => m.Id == id);
            if (place == null)
            {
                return NotFound();
            }

            return View(place);
        }

        // GET: Places/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Places/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,City,Address,Cost,Rate,Time,Status,Type,ReviewPlace")] Place place)
        {
            if (ModelState.IsValid)
            {
                _context.Add(place);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(place);
        }
        //Создать маршрут
        // GET: Route/Create
        public IActionResult AddRoute()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddRoute([Bind("Id,UserID,NameRoute,Discript")] UserRoute userroute)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userroute);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(userroute);
        }

        // GET: Places/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var place = await _context.Place.FindAsync(id);
            if (place == null)
            {
                return NotFound();
            }
            return View(place);
        }

        // POST: Places/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,City,Address,Cost,Rate,Time,Status,Type,ReviewPlace")] Place place)
        {
            if (id != place.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(place);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlaceExists(place.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(place);
        }

        // GET: Places/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var place = await _context.Place
                .FirstOrDefaultAsync(m => m.Id == id);
            if (place == null)
            {
                return NotFound();
            }

            return View(place);
        }

        // POST: Places/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var place = await _context.Place.FindAsync(id);
            _context.Place.Remove(place);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlaceExists(int id)
        {
            return _context.Place.Any(e => e.Id == id);
        }
        [HttpGet]
        public async Task<IActionResult> AddPlace(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var rp = new Bunch();
            rp.PlaceID = id.Value;
            //rp.RoutesId = 
            return View(rp);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddPlace([Bind("Id,PlaceID,UserRouteID ")] Bunch bunch)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bunch);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bunch);
        }
        [HttpGet]
        
        public async Task<IActionResult> AllRoute()
        {
            var m = new RouteViewModel();
            m.AllUserRoutes = _context.UserRoute.ToList();
            m.AllPlaces= _context.Place.ToList();
            m.AllBunch = _context.Bunch.ToList();
            return View(m);
        }

    }
}
