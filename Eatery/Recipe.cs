using System.Collections.Generic;

namespace Eatery
{
    /// <summary>
    /// Сlass recipe dish
    /// </summary>
    public class Recipe
    {
        public List<Ingridient> Ingridients { get; private set; }
        public Recipe(List<Ingridient> ingridients,)
        {
            Ingridients = ingridients;
        }
    }
}
