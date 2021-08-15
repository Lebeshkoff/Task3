using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eatery
{
    /// <summary>
    /// Client
    /// </summary>
    /// <typeparam name="T">Type of id</typeparam>
    public class Client<T>
    {
        /// <summary>
        /// Id
        /// </summary>
        public T Id { get; private set; }

        public Client(T id)
        {
            Id = id;
        }
    }
}
