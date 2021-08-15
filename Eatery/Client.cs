using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eatery
{
    [Serializable]
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

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj as Client<T> == null) return false;
            return true;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
