using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_S.Abstraction
{
    interface IDrawable   //multiple inheritance achiving in this programs
    {
        void draw(); //abstract method here
    }
    class Rectangle1 :IDrawable
    {
        public void draw() //implementing Interface abstract method
        {
            Console.WriteLine("drawing rectangle...");
        }
    }
    public class Circle1 :IDrawable
    {
        public void draw() //implementing Interace abstract method
        {
            Console.WriteLine("drawing circle...");
        }
    }
    public class TestInterface
    {
        public static void Main(String[] args)
        {
            IDrawable d;  //doing Upcasting here;
                                                
            d = new Rectangle1();
            d.draw();
            d = new Circle1();
            d.draw();
        }
    }
