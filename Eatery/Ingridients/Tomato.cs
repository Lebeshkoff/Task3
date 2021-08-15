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

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj as Tomato == null) return false;
            return StorageTemperature == ((Tomato)obj).StorageTemperature &&
                Cost == ((Tomato)obj).Cost;
        }

        public override int GetHashCode()
        {
            return StorageTemperature.GetHashCode() ^ Cost.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public Tomato Cook()
        {
            throw new NotImplementedException();
        }
    }
}
