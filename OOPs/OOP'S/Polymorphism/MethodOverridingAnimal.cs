using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_S.Polymorphism
{
    class MethodOverridingAnimal
    {
        public virtual void eat()  //same function in derived Dog class
        {
            Console.WriteLine("eating...");
        }
    }
    class Dog:MethodOverridingAnimal
    {
        public override void eat()  //same function in MethodOverloadingAnimal class
        {
            Console.WriteLine("eating bread...");
        }

    }
    public class TestPolymorphism
    {
        public static void Main()
        {
            MethodOverridingAnimal a = new Dog();  //doing Upcasting here
            a.eat();
        }
    }
