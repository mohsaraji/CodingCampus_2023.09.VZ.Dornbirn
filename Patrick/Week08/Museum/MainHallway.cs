﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week08.Museum
{
    public class MainHallway : Hallway
    {
        private bool _IsOpen;


        public MainHallway(string name) : base(name)
        {
            _IsOpen = true;
           
        }     
    }
}
