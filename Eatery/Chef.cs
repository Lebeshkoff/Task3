using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eatery
{
    public class Chef
    {
        public string Name { get; private set; }
        public Chef(string name)
        {
            Name = name;
        }

        public Recipe CreateRecipe(Dictionary<Ingridient, Processing> recipe, string name)
        {
            Recipe resultRecipe = new Recipe(name);
            foreach (var item in recipe)
            {
                resultRecipe.AddIngridientAndProcessing(item.Key, item.Value);
            }
            return resultRecipe;
        }
    }
}
