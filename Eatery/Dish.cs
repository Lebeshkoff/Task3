using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eatery
{
    [Serializable]
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

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj as Dish == null) return false;
            return Name == ((Dish)obj).Name &&
                Cost == ((Dish)obj).Cost &&
                Recipe == ((Dish)obj).Recipe;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Cost.GetHashCode() ^ Recipe.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
