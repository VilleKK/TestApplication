using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    class Vector
    {   //Vektorilaskentaa
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        //Konstruktori
        public Vector(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
    }
}
