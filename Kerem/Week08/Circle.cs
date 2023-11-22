﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Week08
{
    internal class Circle  : Geometry
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }
        public override double CircumFerence()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Circle");
            Console.ForegroundColor = ConsoleColor.White;

            return Math.PI * 2 * _radius;
        }
        public override double GetArea()
        {
            return Math.PI * Math.Pow(_radius,2);
        }
    }
}
