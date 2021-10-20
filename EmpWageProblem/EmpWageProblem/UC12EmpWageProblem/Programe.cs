using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageProblem.UC12EmpWageProblem
{
    class Programe
    {
        static void main(String[] ar)
        {
            Console.WriteLine("Welcome to Employee Wage Computation!\n");
            EmpWageBuilderArray emp = new EmpWageBuilderArray();

            emp.addCompanyEmpWage("DMart", 20, 20, 60);
            emp.addCompanyEmpWage("Reliance", 20, 15, 30);
            emp.addCompanyEmpWage("VMware", 10, 20, 30);
            emp.addCompanyEmpWage("Rolex", 15, 10, 60);
            Console.ReadLine();
        }
    }
}
