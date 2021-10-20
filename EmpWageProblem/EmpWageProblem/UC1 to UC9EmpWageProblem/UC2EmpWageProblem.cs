using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageProblem
{
    class UC2EmpWageProblem
    {
        public const int IS_FULL_TIME = 1; //initialize the value of full time employee
        public const int IS_PART_TIME = 2; //initialize the value of part time employee
        public const int Emp_Rate_Per_Hour = 20; //initialize the value of emplayoee rate per hours
        static void Main(string[] args)
        {
            int emphrs = 0;
            int empwage = 0;
            // creating obj of Random Predefine class
            Random random = new Random();
            //using Next() to generaret random input out of 0,1
            int empInput = random.Next(0, 3);
            if (IS_FULL_TIME == empInput)
            {
                Console.WriteLine("Employee is present");
                emphrs = 8;
            }
            else if (IS_PART_TIME == empInput)
            {
                Console.WriteLine("Employee is Part Time present");
                emphrs = 4;
            }
            else
            {
                emphrs = 0;
                Console.WriteLine(" Employee is Absent");
            }
            empwage = emphrs * Emp_Rate_Per_Hour;
            Console.WriteLine("empwagec:" + empwage);
            Console.ReadLine();
        }
    }
}
