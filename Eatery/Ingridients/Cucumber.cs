using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eatery.Processings.IProcessings;

namespace Eatery
{
    /// <summary>
    /// Cucumber
    /// </summary>
    public class Cucumber : Ingridient, IShredable<Cucumber>
    {
        /// <summary>
        /// Create ingridient "Cucumber"
        /// </summary>
        /// <param name="storageTemperature">Storage Temperature</param>
        /// <param name="cost">Cost</param>
        public Cucumber(int storageTemperature, int cost)
        {
            StorageTemperature = storageTemperature;
            Cost = cost;
        }

        public Cucumber Cook()
        {
            throw new NotImplementedException();
        }
    }
}
