using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eatery.Processings.IProcessings;

namespace Eatery.Ingridients
{
    [Serializable]
    public class Salt : Ingridient, IAddble<Salt>
    {
        /// <summary>
        /// Create ingridient "Salt"
        /// </summary>
        /// <param name="storageTemperature">Storage Temperature</param>
        /// <param name="cost">Cost</param>
        public Salt(int storageTemperature, int cost)
        {
            StorageTemperature = storageTemperature;
            Cost = cost;
        }
        public Salt Cook()
        {
            throw new NotImplementedException();
        }
    }
}
