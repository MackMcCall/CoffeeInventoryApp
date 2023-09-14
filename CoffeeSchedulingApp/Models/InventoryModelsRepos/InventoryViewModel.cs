﻿using CoffeeSchedulingApp.Models.CoffeeModelsRepos;
using CoffeeSchedulingApp.Models.UserModelsRepos;

namespace CoffeeSchedulingApp.Models.InventoryModelsRepos
{
    public class InventoryViewModel
    {
        public User ModelUser { get; set; }
        public IEnumerable<Coffee> ModelCoffees { get; set; }
        public int UserAvgGrams { get; set; }
        public int CoffeeTotalGrams { get; set; }
    }
}
