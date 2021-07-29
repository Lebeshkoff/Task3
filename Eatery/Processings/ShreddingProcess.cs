using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eatery.Processings
{
    public class ShreddingProcess : Processing
    {
        public ShreddingProcess(int time, int cost)
        {
            Time = time;
            Cost = cost;
        }
    }
}
