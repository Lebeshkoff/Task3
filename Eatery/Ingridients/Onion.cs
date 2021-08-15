using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eatery.Processings.IProcessings;

namespace Eatery.Ingridients
{
    public class Onion : Ingridient, IShredable<Onion>
    {
        /// <summary>
        /// Create ingridient "Onion"
        /// </summary>
        /// <param name="storageTemperature">Storage Temperature</param>
        /// <param name="cost">Cost</param>
        public Onion(int storageTemperature, int cost)
        {
            StorageTemperature = storageTemperature;
            Cost = cost;
        }

        public Onion Cook()
        {
            throw new NotImplementedException();
        }
    }
}
