using System;
using Eatery.Processings.IProcessings;

namespace Eatery.Processings
{
    /// <summary>
    /// Shred process
    /// </summary>
    public class ShreddingProcess : Processing
    {
        public ShreddingProcess(int time, int cost)
        {
            ProcessingType = typeof(IShredable<>);
            Time = time;
            Cost = cost;
        }
    }
}
