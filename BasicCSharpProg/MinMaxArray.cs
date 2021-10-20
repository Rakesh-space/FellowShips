using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellowShip.BasicCSharpProg
{
    class MinMaxArray
    {
        static void minValue(int[] ar)
        {
            int min = ar[0];
            int max = ar[0];
            for (int i = 0; i < ar.Length; i++)
            {
                if (min > ar[i])
                {
                    min = ar[i];
                }
                else if(max=ar[i])
                {
                    max = ar[i];
                }
                Console.WriteLine("Minimum ele" + min);
                Console.WriteLine("Maximum ele" + max);
            }
        }
        static void main(String args[])
        {
            int[] ar = { 5, 2, 1, 7, 8 };

            minValue(ar);
        }
    }
}
