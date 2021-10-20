using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageProblem
{
    class UC8EmpWageProblem
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        public static int uC8EmpWageProblem(string Company, int empRatePerhour, int NoofWorkingDays, int MaxHourPerMonth)
        {
            
            int totalemphour = 0;
            int emphrs = 0;

            int totalW0rkingDay = 0;
            int empwage = 0;
            while (totalemphour <= MaxHourPerMonth && totalW0rkingDay < NoofWorkingDays)
            {

                totalW0rkingDay++;
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
                totalemphour += emphrs;

                //totalW0rkingDay += emphrs;//
                Console.WriteLine("Days#:" + totalW0rkingDay);
                Console.WriteLine("Emp hrs:" + emphrs);
            }
            int totalEmpWage = totalemphour * empRatePerhour;
            Console.WriteLine("Total Emp Wage :" + totalEmpWage);
            return totalEmpWage;
        }
        static void Main(string[] args)
        {
            uC8EmpWageProblem("DMart", 20, 2, 10);
            uC8EmpWageProblem("Reliance", 10, 4, 20);
            Console.ReadLine();
        }
    }
    }
}
