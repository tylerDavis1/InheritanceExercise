﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Animal
    {

        public Animal() { }
        public bool IsAlive { get; set; }
        public int MaybeHasLegs { get; set; }

        public string ShowThatSpeed { get; set; }

        public string LandAirSea { get; set; }
    }
}
