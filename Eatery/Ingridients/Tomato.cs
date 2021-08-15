using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eatery.Processings.IProcessings;

namespace Eatery
{
    /// <summary>
    /// Create ingridient "Tomato"
    /// </summary>
    /// <param name="storageTemperature">Storage Temperature</param>
    /// <param name="cost">Cost</param>
    public class Tomato : Ingridient, IShredable<Tomato>
    {
        public Tomato(int storageTemperature, int cost)
        {
            StorageTemperature = storageTemperature;
            Cost = cost;
        }

        public Tomato Cook()
        {
            throw new NotImplementedException();
        }
    }
}
