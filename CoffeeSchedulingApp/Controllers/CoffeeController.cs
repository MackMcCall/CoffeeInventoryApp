﻿using CoffeeSchedulingApp.Models.CoffeeModelsRepos;
using Microsoft.AspNetCore.Mvc;
using System.Security.Policy;

namespace CoffeeSchedulingApp.Controllers
{
    public class CoffeeController : Controller
    {
        private readonly ICoffeeRepo _repo;

        public CoffeeController(ICoffeeRepo repo)
        {
            _repo = repo;
        }
        
        public IActionResult ViewCoffee(int id)
        {
            var coffee = _repo.GetCoffee(id);
            return View(coffee);
        }

        public IActionResult UpdateCoffee(int id)
        {
            Coffee coffee = _repo.GetCoffee(id);
            if (coffee == null)
            {
                return View("Coffee Not Found");
            }
            return View(coffee);
        }

        public IActionResult UpdateCoffeeToDatabase(Coffee coffee)
        {
            _repo.UpdateCoffee(coffee);

            return RedirectToAction("ViewCoffee", new { id = coffee.CoffeeID });
        }

        public IActionResult InsertCoffee(Coffee coffeeToInsert)
        {
            return View(coffeeToInsert);
        }

        public IActionResult InsertCoffeeToDatabase(Coffee coffeeToInsert)
        {
            _repo.InsertCoffee(coffeeToInsert);
            return RedirectToAction("Index", "Inventory");
        }
    }
}

//controls the things related to the coffee views