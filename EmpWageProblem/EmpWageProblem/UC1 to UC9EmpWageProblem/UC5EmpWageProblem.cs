using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageProblem
{
    class UC5EmpWageProblem
    {

        public const int IS_FULL_TIME = 1; //initialize the value of full time employee
        public const int IS_PART_TIME = 2; //initialize the value of part time employee
        public const int Emp_Rate_Per_Hour = 20; //initialize the value of emplayoee rate per hours
        public const int NUM_WORKING_DAY = 2; //initialize the value of No of working days
        static void Main(string[] args)
        {
            int emphrs = 0;
            int empwage = 0;
            int totalempwage = 0;

            for (int day = 0; day < NUM_WORKING_DAY; day++)
            {
                // creating obj of Random Predefine class
                Random random = new Random();
                //using Next() to generaret random input out of 0,1
                int empcheck = random.Next(0, 3);

                switch (empcheck)
                {
                    case IS_FULL_TIME:
                        Console.WriteLine("Employee is FULL Time Present");
                        emphrs = 8;
                        break;
                    case IS_PART_TIME:
                        Console.WriteLine("Employee is Part Time Present");

                        emphrs = 4;
                        break;
                    default:
                        Console.WriteLine("Employee is Absent");
                        emphrs = 0;
                        break;

                }
                empwage = emphrs * Emp_Rate_Per_Hour;
                totalempwage += emphrs;
                Console.WriteLine("empwagec:" + empwage);
                Console.ReadLine();
            }
        }
    }
}
