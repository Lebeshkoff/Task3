using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eatery
{
    public class Client<T>
    {
        public T Id { get; private set; }

        public Client(T id)
        {
            Id = id;
        }
    }
}
