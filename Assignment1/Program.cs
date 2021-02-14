using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            int x = 0;
            int l = 1, w = 1;
            do
            {
                Console.WriteLine("Select Option from Menu:");
                Console.WriteLine("1. Get Rectangle Length \n"+
                                   "2.Change Rectangle Length \n" +
                                   "3.Get Rectangle Width\n" +
                                   "4.Change Rectangle Width\n" +
                                   "5.Get Rectangle Perimeter\n" +
                                   "6.Get Rectangle Area\n" +
                                   "7.Exit\n");
                Console.Write("Enter Option: ");
                x = int.Parse(Console.ReadLine());
                if (x == 1) {
                    Console.WriteLine("Length of Rectangle : " + r.GetLength());
                } else if (x == 2) {
                    Console.Write("Enter New Length of Rectangle: ");
                    l = int.Parse(Console.ReadLine());
                    if (l < 1) {
                        Console.WriteLine("Length of Rectangle Cannot be less than 1");
                    } else{
                        r.SetLenght(l);
                    }
                } else if (x == 3) {
                    Console.WriteLine("Width of Rectangle : " + r.GetWidth());
                } else if (x == 4) {
                    Console.Write("Enter New Width of Rectangle: ");
                    w = int.Parse(Console.ReadLine());
                    if (w < 1) {
                        Console.WriteLine("Width of Rectangle Cannot be less than 1");
                    } else {
                        r.SetWidth(w);
                    }
                } else if (x == 5) {
                    Console.WriteLine("Perimeter of Rectangle : " + r.GetPerimeter());
                } else if (x == 6) {
                    Console.WriteLine("Area of Rectangle : " + r.GetArea());
                } else if (x == 7) {
                    Console.WriteLine("Thank You");
                } else {
                    Console.WriteLine("Select Option Properly");
                }Console.WriteLine("\n\n\n");
            } while (x != 7);
        }
    }
}
