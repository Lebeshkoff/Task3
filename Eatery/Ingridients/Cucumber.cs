using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eatery.Processings.IProcessings;

namespace Eatery
{
    public class Cucumber : Ingridient, IShredable<Cucumber>
    {
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
