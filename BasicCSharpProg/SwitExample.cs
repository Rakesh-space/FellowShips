using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellowShip.BasicCSharpProg
{
       class SwitExample
       {
           static void main(String args[])
           {
               Console.WriteLine("Enter the Days no:");
               int no = Convert.ToInt32(Console.ReadLine());

               switch(no)
               {
                   case 1:Console.WriteLine("Monday");
                       break;

                   case 2:Console.WriteLine("Tuesday");
                       break;
                   case 3: Console.WriteLine("Wednesday");
                       break;
                   case 4: Console.WriteLine("Thursday");
                       break;
                   case 5:Console.WriteLine("Friday");
                       break;
                   case 6:Console.WriteLine("Saturday");
                       break;
                   case 7:Console.WriteLine("Sunday");
                       break;

                   default:Console.WriteLine("Wrong Choice...");
                       break;
               }
           }
       }
}
