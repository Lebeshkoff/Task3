using System.Collections.Generic;
using System;

namespace Eatery
{
    [Serializable]
    /// <summary>
    /// Сlass recipe dish
    /// </summary>
    public class Recipe
    {
        /// <summary>
        /// Recipe
        /// </summary>
        public Dictionary<Ingridient,Processing> Ingridients { get; private set; }
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// Cost
        /// </summary>
        public int Cost { get; private set; }
        /// <summary>
        /// Cooking time
        /// </summary>
        public int CookingTime { get; private set; }

        /// <summary>
        /// Create new recipy
        /// </summary>
        /// <param name="name">Name</param>
        public Recipe(string name)
        {
            Ingridients = new Dictionary<Ingridient, Processing>();
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

        /// <summary>
        /// Add item to recipe
        /// </summary>
        /// <param name="ingridient">Ingridient</param>
        /// <param name="processing">Processing</param>
        public void AddIngridientAndProcessing(Ingridient ingridient, Processing processing)
        {
            foreach (var interfaceType in ingridient.GetType().GetInterfaces())
            {
                if(interfaceType.Name == processing.ProcessingType)
                {
                    Ingridients.Add(ingridient, processing);
                    CalculateCostAndCookingTime();
                    return;
                }
            }
            throw new Exception("Incorrect ingridient with processing type");
        }
    }
}
