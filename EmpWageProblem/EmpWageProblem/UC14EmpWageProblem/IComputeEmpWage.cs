using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageProblem.UC13EmpWageProblem
{
    public abstract class IComputeEmpWage
    {
        public abstract void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDay, int maxHoursPerMonth);
        public abstract void computeEmpWage(string company, int empRatePerHour, int numOfWorkingDay, int maxHoursPerMonth);
        public abstract void getTotalWage(string compnay);

    }

}
