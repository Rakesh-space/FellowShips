using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_S.Inheritance
{
    class Employee
    {
        public float salary = 40000;  //Parent class variable
    }
    class Programmer : Employee
    {
        public float bonus = 10000; //child class variable
    }
    class TestInheritance
    {
        public static void Main(string[] args)
        {
            Programmer p1 = new Programmer();

            Console.WriteLine("Salary: " + p1.salary);
            Console.WriteLine("Bonus: " + p1.bonus);

        }
    }
