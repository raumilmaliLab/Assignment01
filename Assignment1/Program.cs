using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            Console.WriteLine("Area of Rectangle =" + r.GetArea());
            Console.WriteLine("Perimeter of Rectangle =" + r.GetPerimeter());

            Rectangle r1 = new Rectangle(4, 3);
            Console.WriteLine("Area of Rectangle =" + r1.GetArea());
            Console.WriteLine("Perimeter of Rectangle =" + r1.GetPerimeter());
        }
    }
}
