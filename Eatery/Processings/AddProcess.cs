using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eatery.Processings.IProcessings;

namespace Eatery.Processings
{
    public class AddProcess : Processing
    {
        public AddProcess(int time, int cost)
        {
            ProcessingType = typeof(IAddble<>);
            Time = time;
            Cost = cost;
        }
     }
}
