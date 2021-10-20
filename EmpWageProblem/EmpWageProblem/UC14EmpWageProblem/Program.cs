using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageProblem.UC13EmpWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                EmpWageBuilderList empWageBulder = new EmpWageBuilderList();
                empWageBulder.addCompanyEmpWage("D-Mart", 20, 6, 20);
                empWageBulder.addCompanyEmpWage("Reliance", 20, 6, 20);
                empWageBulder.computeEmpWage();
                Console.WriteLine("Total Emp wage D-Mart company:" + EmpWageBuilderList.getTotalWage("D-mart"));
                Console.ReadLine();
            }
        }
    }
}
