using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eatery
{
    [Serializable]
    /// <summary>
    /// summarize ingridients
    /// </summary>
    public abstract class Ingridient
    {
        /// <summary>
        /// Storage temperature
        /// </summary>
        public int StorageTemperature { get; protected set; }
        /// <summary>
        /// Cost
        /// </summary>
        public int Cost { get; protected set; }

    }
}
