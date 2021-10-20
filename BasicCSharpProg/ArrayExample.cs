using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellowShip.BasicCSharpProg
{
    class ArrayExample
    {
        public void ArrayExa()
        {
            int[] arrr = new int[6];

            arrr[1] = 10;
            arrr[3] = 50;
            arrr[6] = 80;

            for (int i = 0; i < arrr.Length; i++)
            {
                Console.WriteLine(arrr);
            }
        }
    }
}
