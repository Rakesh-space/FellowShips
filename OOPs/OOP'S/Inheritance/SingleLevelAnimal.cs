using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_S.Inheritance
{
        class SingleLevelAnimal  //parent class here
        {
            public void eat() 
            {
                Console.WriteLine("Eating..."); 
            }
        }
        class Dog :SingleLevelAnimal  // child class here 
        {
            public void bark() 
            {
                Console.WriteLine("Barking..."); 
            }
        }
        class TestInheritance2
        {
            public static void Main(string[] args)
            {
                Dog d1 = new Dog();
                d1.eat();
                d1.bark();
            }
        }
}
