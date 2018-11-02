using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringDebugging
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5, 6 };
            //int i = 0;                         //Unessesary variable
            //for (i = 0; i < array1.Length; i++)//loop not necessary
            //{                                  //
            //    array1[i]++;                   //
            //}                                  //
            int result = GetSum(array1);
            Console.WriteLine(result);
        }
        static private int GetSum(int[] array1)//static -- void->int
        {
            int sum = 0;                       //initialized from 1 to 0
            foreach (int item in array1)
            {
                sum = sum + item;
            }
            return sum;                        //return value
        }
    }
}
