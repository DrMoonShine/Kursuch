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

        private readonly MvcPlaceContext _context;

        public PlacesController(MvcPlaceContext context)
        {
            _context = context;
        }
        //Метотд GET используется по умолчанию, поэтому [HttpGet] можно не писать
        // GET: Places
        public async Task<IActionResult> Index(string placeCitys, string searchString)
        {
            IQueryable<string> genreQuery = from p in _context.Movie //movie = place(имя таблице перепутано)
                                            orderby p.City
                                            select p.City;

            var places = from p in _context.Movie
                         select p;

            if (!string.IsNullOrEmpty(searchString)) // Если не null
            {
                places = places.Where(s => s.NamePlace.Contains(searchString)); //Название введенное пользователем 
            }

            if (!string.IsNullOrEmpty(placeCitys)) //Если не null
            {
                places = places.Where(x => x.City == placeCitys); //Фильтр города
            }
            //передача полученныех и отсортированных данных
            var placeVM = new PlaceViewModel 
            {
                Citys = new SelectList(await genreQuery.Distinct().ToListAsync()),
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

            var place = await _context.Movie
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

        // GET: Places/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var place = await _context.Movie.FindAsync(id);
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

            var place = await _context.Movie
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
            var place = await _context.Movie.FindAsync(id);
            _context.Movie.Remove(place);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlaceExists(int id)
        {
            return _context.Movie.Any(e => e.Id == id);
        }
    }
}
