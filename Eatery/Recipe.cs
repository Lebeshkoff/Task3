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
            int tempCost = 0;
            int tempTime = 0;
            foreach (var ingridient in Ingridients)
            {
                tempCost += ingridient.Value.Cost + ingridient.Key.Cost;
                tempTime += ingridient.Value.Time;
            }
            Cost = tempCost;
            CookingTime = tempTime;
        }

        public void AddIngridientAndProcessing(Ingridient ingridient, Processing processing)
        {
            foreach (var interfaceType in ingridient.GetType().GetInterfaces())
            {
                if(interfaceType == processing.ProcessingType)
                {
                    break;
                }
            }
            Ingridients.Add(ingridient, processing);
            CalculateCostAndCookingTime();
        }
    }
}
