﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmet.Week07.Museum
{
    public abstract class Artwork
    {
        private string _ArtName;

        public Artwork(string artName)
        {
            _ArtName = artName;
        }
    }
}