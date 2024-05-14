using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
     class Bird : Animal 
    {
        public Bird() { }

        public string BirdType { get; set; }
        public string WingColor { get; set; }

        public bool CanFly { get; set; }

        public bool IsProtected { get; set; }

    }
}
