using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageProblem
{
    class UC1EmpWageProblem
    {
        static void Main(string[] args)
        {
            int IS_FULL_TIME = 1;
            Random random = new Random();

            int empCheck = random.Next(0,2);
            if(empCheck==IS_FULL_TIME)
            {
                Console.WriteLine("\n Employee Present..");
            }
            else
            {
                Console.WriteLine("\n Employee is Absent..");
            }
            Console.ReadLine();
        }
    }
}
