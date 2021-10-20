using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellowShip.BasicCSharpProg
{
   class EvenOdd
   {
       static void main(String args[])
       {
           Console.WriteLine("Enter the no:");
           int num = Convert.ToInt32(Console.ReadLine());

           if (num % 2 == 0)
           {
               Console.Write("No is even");
           }
           else
           {
               Console.WriteLine("No is odd");
           }
       }
   }

}
