using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageProblem.UC12EmpWageProblem
{
    class ComputeEmpWage : IComputeEmpWage
    {
        public string company;
        public int empRatePerHour;
        public int numOfWorkingDay;
        public int maxHoursPerMonth;
        public int totalEmpWage;

        public ComputeEmpWage(string company, int empRatePerHour, int numOfWorkingDay, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDay = numOfWorkingDay;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }

        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }

        public string toString()
        {
            return "Total Emp wage for company:" + this.company + " " + "is " + this.totalEmpWage;
        }
    }
}
