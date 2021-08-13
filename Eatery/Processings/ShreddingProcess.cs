using System;
using Eatery.Processings.IProcessings;

namespace Eatery.Processings
{
    public class ShreddingProcess : Processing
    {
        public ShreddingProcess(int time, int cost)
        {
            processingType = typeof(IShredable<>);
            Time = time;
            Cost = cost;
        }
    }
}
