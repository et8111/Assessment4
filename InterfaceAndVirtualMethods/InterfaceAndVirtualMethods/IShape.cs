using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndVirtualMethods
{
    class IShape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Hi, i am a shape.");
        }
    }
}
