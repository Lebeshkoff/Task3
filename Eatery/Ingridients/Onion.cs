using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eatery.Ingridients
{
    public class Onion : Ingridient
    {
        public Onion(int storageTemperature, int cost)
        {
            StorageTemperature = storageTemperature;
            Cost = cost;
        }
    }
}
