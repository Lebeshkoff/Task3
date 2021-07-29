using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eatery
{
    public abstract class Ingridient
    {
        public int StorageTemperature { get; protected set; }
        public int Cost { get; protected set; }

    }
}
