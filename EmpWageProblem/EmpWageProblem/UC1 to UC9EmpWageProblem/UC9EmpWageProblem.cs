using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageProblem.UC1_to_UC9EmpWageProblem
{
    class UC9EmpWageProblem
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;


        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;
        public UC9EmpWageProblem(String company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void computeEmpWage()
        {
            int empHrs = 0, totalWorkDays = 0, totalEmpHrs = 0;
            while (totalEmpHrs <= this.maxHoursPerMonth && totalWorkDays < this.numOfWorkingDays)
            {
                totalWorkDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 4);

                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkDays + " Emp Hrs : " + empHrs);
            }
            totalEmpWage = totalEmpHrs * this.empRatePerHour;
            Console.WriteLine("Total Employee Wage for company:" + company + " is: " + totalEmpWage);
        }
        class Program
        {
            public static void Main(String[] args)
            {
                UC9EmpWageProblem dMart = new UC9EmpWageProblem("DMart", 20, 2, 10);
                UC9EmpWageProblem Vguard = new UC9EmpWageProblem("Vguard", 10, 2, 10);
                UC9EmpWageProblem reliance = new UC9EmpWageProblem("Reliancet", 10, 4, 20);
                dMart.computeEmpWage();
                Console.WriteLine(dMart.ToString());
                Vguard.computeEmpWage();
                Console.WriteLine(Vguard.ToString());
                reliance.computeEmpWage();
                Console.WriteLine(reliance.ToString());

                Console.ReadLine();

            }
        }

    }
}
