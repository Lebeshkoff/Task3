using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eatery
{
    public abstract class Processing
    {
        public int Cost { get; protected set; }
        public int Time { get; protected set; }

        public abstract void Process();
    }
}
