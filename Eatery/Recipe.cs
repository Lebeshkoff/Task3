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

        public Recipe(Dictionary<Ingridient, Processing> ingridients, string name)
        {
            Ingridients = ingridients;
            Name = name;
        }

        /// <summary>
        /// Calculate cost price
        /// </summary>
        private void CalculateCost()
        {
            throw new NotImplementedException();
        }

        public void AddIngridientAndProcessing()
        {
            CalculateCost();
        }
    }
}
