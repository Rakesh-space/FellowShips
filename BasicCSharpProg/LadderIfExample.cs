using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellowShip.BasicCSharpProg
{
     class LadderIfExample
     {
         static void main(String ar[])
         {
             Console.WriteLine("Enter the grade:");
             int grade = Convert.ToInt32(Console.ReadLine());

             if (grade >= 80 && grade <= 90)
             {
                 Console.WriteLine("Distingtion ......");
             }
             else if (grade >= 60 && grade <= 80)
             {
                 Console.WriteLine("First Class....");
             }
             else if (grade >= 50 && grade <= 60)
             {
                 Console.WriteLine("Secound Class");
             }
             else
             {
                 Console.WriteLine("Fail...");
             }
         }
     }

}
