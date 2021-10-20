using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellowShip.BasicCSharpProg
{
    class ArrExample1
    {
        static void main(String ar[])
        {
            int[] arr = new int[] { 10, 20, 30, 40, 50 };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr);
            }
        }
    }
}
