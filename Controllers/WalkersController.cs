using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dog_Go.Models;
using Dog_Go.Models.ViewModels;
using Dog_Go.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Dog_Go.Controllers
{
    public class WalkersController : Controller
    {
        private readonly WalkerRepository _walkerRepo;
        private readonly WalksRepository _walksRepo;
        private readonly NeighborhoodRepository _neighborhoodRepo;
        private object walkers;

        // The constructor accepts an IConfiguration object as a parameter. This class comes from the ASP.NET framework and is useful for retrieving things out of the appsettings.json file like connection strings.
        public WalkersController(IConfiguration config)
        {
            _walkerRepo = new WalkerRepository(config);
            _walksRepo = new WalksRepository(config);
            _neighborhoodRepo = new NeighborhoodRepository(config);
        }
        // GET: List of all dog walkers
        public ActionResult Index()
        {
            List<Walker> walkers = _walkerRepo.GetAllWalkers();
            return View(walkers);
        }

        // GET: A specific dog walker by Id
        public ActionResult Details(int id)
        {
            Walker walker = _walkerRepo.GetWalkerById(id);
            List<Walks> walks = _walksRepo.GetWalksByWalkerId(id);
            Neighborhood neighborhood = _neighborhoodRepo.GetNeighborhoodById(id);

            WalkerProfileViewModel walkerPVM = new WalkerProfileViewModel
            {
                Walker = walker,
                Walks = walks,
                Neighborhood = neighborhood
            };

            return View(walkerPVM);
        }

        // GET: Create a new dog walker
        public ActionResult Create()
        {
            Walker walker = new Walker();
            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}