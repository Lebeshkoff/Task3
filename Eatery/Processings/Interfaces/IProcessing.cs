using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eatery.Processings.IProcessings
{
    /// <summary>
    /// Cook inggridient
    /// </summary>
    /// <typeparam name="T">Ingridient whitch cook</typeparam>
    public interface IProcessing<T>
    {
        /// <summary>
        /// Cook ingridient
        /// </summary>
        /// <returns>ingridient</returns>
        public T Cook(); 
    }
}
