using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eatery.Processings.IProcessings
{
    /// <summary>
    /// Add process
    /// </summary>
    /// <typeparam name="T">Ingridient</typeparam>
    public interface IAddble<T> : IProcessing<T>
    {

    }
}
