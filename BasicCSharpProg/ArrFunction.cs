using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellowShip.BasicCSharpProg
{
    class ArrFunction
    {
        static void printArray(int[] arrr)
        {
            Console.WriteLine("Array ele is:");
            for (int i = 0; i < arrr.Length; i++)
            {
                Console.WriteLine(arrr);
            }
        }
        static void main(String[] ar)
        {
            int[] ar={ 10, 20, 30 };
            printArray(ar);
        }
    }
}
