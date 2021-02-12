using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    public class Rectangle
    {
        public int length, width;
        public Rectangle()
        {
            length = 1;
            width = 1;
        }
        public Rectangle(int length, int width)
        {
            this.length = SetLenght(length);
            this.width = SetWidth(width);
        }
        public int GetLength()
        {
            return length;
        }
        public int SetLenght(int length)
        {
            this.length = length;
            return length;
        }

        public int GetWidth()
        {
            return width;
        }
        public int SetWidth(int width)
        {
            this.width = width;
            return width;
        }

        public int GetPerimeter()
        {
            return(2 * (length + width));
        }
        public int GetArea()
        {
            return (length * width);
        }
    }
}
