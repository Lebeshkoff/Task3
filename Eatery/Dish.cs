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

        public Dish(Recipe recipe, int extraCharge)
        {

        }
    }
}
