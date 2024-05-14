using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile: Animal
    {

        public Reptile() { }

        public bool IsDangerous { get; set; }
        public string ReptileType { get; set; }

        public bool IsColdBlooded { get; set; }

        public string Habitate { get; set; }

    }
}
