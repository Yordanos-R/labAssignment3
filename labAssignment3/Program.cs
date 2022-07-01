using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labAssignment3
{
    internal class Program
    {
        public abstract class Shape 
        {
            public abstract double calculateArea();
            public abstract double calculatePerimeter();
        }
        public class Circle : Shape
        {
            public int radius { get; set; }
            static readonly double pi = 3.14;
            public override double calculateArea()
            {
                return radius * radius * pi;
            }

            public override double calculatePerimeter()
            {
                return 2 * pi * radius;
            }
        }
        public class Rectangle : Shape
        {
            public int length { get; set; }
            public int width { get; set; }

            public override double calculateArea()
            {
                return length * width;
            }

            public override double calculatePerimeter()
            {
                return 2 * (length + width);
            }
        }
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine(" Press 1 for circle and 2 for rectangle");
            x = int.Parse(Console.ReadLine());
            if (x == 1)
            {
                Circle c = new Circle();
                Console.WriteLine("Enter the radius");
                c.radius=int.Parse(Console.ReadLine());
                Console.WriteLine("The Area = " + c.calculateArea());
                Console.WriteLine("The Perimeter = " + c.calculatePerimeter());
                Console.Read();
            }
            else if (x == 2)
            {
                Rectangle r = new Rectangle();
                Console.WriteLine("Enter the length");
                r.length=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the width");
                r.width=int.Parse(Console.ReadLine());
                Console.WriteLine("The Area  = " + r.calculateArea());
                Console.WriteLine ("The Perimeter = " + r.calculatePerimeter());
                Console.Read();
            }
            else
            {
                Console.WriteLine("INVALID INPUT!");
                Console.Read ();
            }

        }
    }
}
