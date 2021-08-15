using System;
using Eatery.Processings.IProcessings;

namespace Eatery.Processings
{
    [Serializable]
    /// <summary>
    /// Shred process
    /// </summary>
    public class ShreddingProcess : Processing
    {
        public ShreddingProcess(int time, int cost)
        {
            ProcessingType = typeof(IShredable<>).Name;
            Time = time;
            Cost = cost;
        }
    }
}
