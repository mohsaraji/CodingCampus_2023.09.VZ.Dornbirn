﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timo.Week07._06Car
{
    public class FuelTank : Tank
    {
        private string _Name;
        private double _MaxCapacity;
        private double _Capacity;
        public FuelTank(string name, double maxCapacity) : base(name, maxCapacity)
        {
        }
    }
}
