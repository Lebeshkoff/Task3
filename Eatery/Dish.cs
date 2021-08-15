using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eatery
{
    public class Dish
    {
        public Recipe Recipe { get; private set; }
        public int Cost { get; private set; }
        public string Name { get; private set; }

        public Dish(string name, Recipe recipe, int extraCharge)
        {
            Name = name;
            Recipe = recipe;
            Cost = recipe.Cost + extraCharge;
        }
    }
}
