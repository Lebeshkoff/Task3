using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eatery.Processings.IProcessings;

namespace Eatery
{
    [Serializable]
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

        public override bool Equals(object obj)
        {
            if(obj == null) return false;
            if (obj as Cucumber == null) return false;
            return StorageTemperature == ((Cucumber)obj).StorageTemperature &&
                Cost == ((Cucumber)obj).Cost;
        }

        public override int GetHashCode()
        {
            return StorageTemperature.GetHashCode() ^ Cost.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public Cucumber Cook()
        {
            throw new NotImplementedException();
        }
    }
}
