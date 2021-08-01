﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eatery.Processings.IProcessings;

namespace Eatery.Ingridients
{
    public class Salt : Ingridient, IAddble<Salt>
    {
        public Salt(int storageTemperature, int cost)
        {
            StorageTemperature = storageTemperature;
            Cost = cost;
        }

        public Salt Cook()
        {
            throw new NotImplementedException();
        }
    }
}