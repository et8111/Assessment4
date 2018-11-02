using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndVirtualMethods
{
    class Square: IShape
    {
        public double Side { get; set; }

        public Square()
        {
            Side = 0;
        }

        public Square(double s)
        {
            Side = s;
        }

        public override void Draw()
        {
            Console.WriteLine("Hi, I am a square!");
        }

        public double GetArea()
        {
            return Side * Side;
        }
    }
}
