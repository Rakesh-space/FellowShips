using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageProblem.UC13EmpWageProblem
{
    class EmpWageBuilderList : IComputeEmpWage
    {

        private int numofcompany = 0;
        private ComputeEmpWage[] computeEmpWageArray;

        public EmpWageBuilderList()
        {
            this.computeEmpWageArray = new ComputeEmpWage[5];
        }

        public void addCompanyEmpWage(string company, int EmpRatePerHrs, int Num_Of_Working_Days, int WorkingHrs)
        {
            ComputeEmpWage companyEmpWage = new ComputeEmpWage(company, EmpRatePerHrs, Num_Of_Working_Days, WorkingHrs);
            this.computeEmpWageArray.AddLast(companyEmpWage);
            this.computeEmpWageArray.Add(company, companyEmpWage);
            computeEmpWageArray[this.numofcompany] = new ComputeEmpWage(company, EmpRatePerHrs, Num_Of_Working_Days, WorkingHrs);
            numofcompany++;
        }

        public void ComputeEmpWage()
        {
            int i = Convert.ToInt32(Console.ReadLine());
            int noOfCompany = 4;
            for (i = 0; i < noOfCompany; i++)
            {
                computeEmpWageList.AddLast(this.computeEmpWageList.AddLast(i));
                Console.WriteLine(computeEmpWageList.ToString());

            }
        }
        public int checkEmpTime(int empInput)
        {

            const int IS_FullTime = 1;
            const int IS_PartTime = 2;

           
            int empHrs = 0;

            switch (empInput)
            {
                case IS_FullTime:
                    return empHrs = 8;

                case IS_PartTime:

                    return empHrs = 4;

                default:

                    return empHrs = 0;
            }

        }


        private int empWageCompute(ComputeEmpWage computeEmpWage)
        {
                int totalEmpHrs = 0, empHrs = 0, totalWorkingDays = 0;

                while (totalEmpHrs <= computeEmpWage.WorkingHrs && totalWorkingDays < computeEmpWage.Num_Of_Working_Days)
                {
                    Random r = new Random();
                    int empInput = r.Next(0, 3);
                    //Console.WriteLine(empInput);
                    empHrs = checkEmpTime(empInput);

                    //int empWage = EmpRatePerHrs * empHrs;
                    totalEmpHrs += empHrs;
                    Console.WriteLine("Days:" + totalWorkingDays + "Emp Hrs: " + empHrs);

                }

                return totalEmpHrs * computeEmpWage.EmpRatePerHrs;

            }
            public int getTotalWage(string company)
            {
                return this.ComputeEmpWage[company].totalEmpWage;

            }
    }
}
