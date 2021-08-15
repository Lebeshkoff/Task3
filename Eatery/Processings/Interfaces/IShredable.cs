using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eatery.Processings.IProcessings
{
    /// <summary>
    /// Shred process
    /// </summary>
    /// <typeparam name="T">Ingridient</typeparam>
    public interface IShredable<T> : IProcessing<T>
    {
    }
}
