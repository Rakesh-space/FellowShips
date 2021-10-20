using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_S.Inheritance
{
    class MultiLevelAnimal  //Parent class here
    {
        public void eat() 
        {
            Console.WriteLine("Eating..."); 
        }
    }
    class Dog1 :MultiLevelAnimal  //Base class here
    {
        public void bark()
        { 
            Console.WriteLine("Barking...");
        }
    }
    class BabyDog1 : Dog1 // Dog1 Parent class inherited from BabyDog1 
    {
        public void weep() 
        { 
            Console.WriteLine("Weeping...");
        }
    }
    class TestInheritance3
    {
        public static void Main(string[] args)
        {
            BabyDog1 d1 = new BabyDog1();
            d1.eat();
            d1.bark();
            d1.weep();
        }
    }
