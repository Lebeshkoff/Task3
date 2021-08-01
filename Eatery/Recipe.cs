using System.Collections.Generic;
using System;

namespace Eatery
{
    /// <summary>
    /// Сlass recipe dish
    /// </summary>
    public class Recipe
    {
        public Dictionary<Ingridient,Processing> Ingridients { get; private set; }
        public string Name { get; private set; }
        public int Cost { get; private set; }
        public int CookingTime { get; private set; }

        public Recipe(Dictionary<Ingridient, Processing> ingridients, string name)
        {
            Ingridients = ingridients;
            Name = name;
        }

        /// <summary>
        /// Calculate cost price and cooking price
        /// </summary>
        private void CalculateCostAndCookingTime()
        {
            
            throw new NotImplementedException();
        }

        public void AddIngridientAndProcessing()
        {
            CalculateCostAndCookingTime();
        }
    }
}
