using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eatery
{
    public class Dish
    {
        /// <summary>
        /// Recipe
        /// </summary>
        public Recipe Recipe { get; private set; }
        /// <summary>
        /// Cost
        /// </summary>
        public int Cost { get; private set; }
        /// <summary>
        /// Dish name
        /// </summary>
        public string Name { get; private set; }

        public Dish(string name, Recipe recipe, int extraCharge)
        {
            Name = name;
            Recipe = recipe;
            Cost = recipe.Cost + extraCharge;
        }
    }
}
