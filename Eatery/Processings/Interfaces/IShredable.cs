﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eatery.Processings.IProcessings
{
    public interface IShredable<T> where T : Ingridient, IProcessing<T>
    {
    }
}