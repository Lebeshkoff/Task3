using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eatery.Processings.IProcessings;

namespace Eatery.Ingridients
{
    [Serializable]
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

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj as Onion == null) return false;
            return StorageTemperature == ((Onion)obj).StorageTemperature &&
                Cost == ((Onion)obj).Cost;
        }

        public override int GetHashCode()
        {
            return StorageTemperature.GetHashCode() ^ Cost.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public Onion Cook()
        {
            throw new NotImplementedException();
        }
    }
}
