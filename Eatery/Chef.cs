using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eatery
{
    [Serializable]
    /// <summary>
    /// Chef
    /// </summary>
    public class Chef
    {
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// Create chef with name
        /// </summary>
        /// <param name="name"></param>
        public Chef(string name)
        {
            Name = name;
        }
        /// <summary>
        /// Create and validate new recipe
        /// </summary>
        /// <param name="recipe">recepi</param>
        /// <param name="name">name of recipe</param>
        /// <returns>Recipe</returns>
        public Recipe CreateRecipe(Dictionary<Ingridient, Processing> recipe, string name)
        {
            Recipe resultRecipe = new Recipe(name);
            foreach (var item in recipe)
            {
                resultRecipe.AddIngridientAndProcessing(item.Key, item.Value);
            }
            return resultRecipe;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj as Chef == null) return false;
            return Name == ((Chef)obj).Name;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
