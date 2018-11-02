using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndVirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Square s1 = new Square();
            s1.Draw();

            Square s2 = new Square();
            Console.WriteLine(s2.GetArea());

            Square s3 = new Square(5);
            Console.WriteLine(s3.GetArea());
        }
    }
}
//S - Shape provides a framework for all that inherit it
     //framework for Squares 
//O - 
    //Square take draw. and modify it for square.
//L - Square could run independently from IShape
//I - Square inherites/immpliments Draw to declare its a Square
//D - Square only takes what it needs to be a shape