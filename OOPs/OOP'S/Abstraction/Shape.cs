using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_S.Abstraction
{
        abstract class Shape  //abstract class here;
        {
            public abstract void draw();  //abstract method here;
        }
        class Rectangle : Shape
        {
            public override void draw() //implementing abstract method
            {
                Console.WriteLine("drawing rectangle...");
            }
        }
        class Circle : Shape
        {
            public override void draw() //implementing abstract method
        {
                Console.WriteLine("drawing circle...");
            }
        }
        class TestAbstract
        {
            static void Main(String[] args)
            {
                Shape s;                //doing upcasting here;
                s = new Rectangle();  
                s.draw();
                s = new Circle();
                s.draw();
            }
        }
}
