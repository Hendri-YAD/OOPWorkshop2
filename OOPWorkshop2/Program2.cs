using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWorkshop2
{
    class Program2
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(10, 6);
            Console.WriteLine(r.StrValue());
            Console.WriteLine(r.Perimeter);
            Console.WriteLine(r.Area);         
        }
    }

    class Rectangle
    {
        double length, breadth;

        public Rectangle(double l, double b)
        {
            length = l;
            breadth = b;
        }

        public double Length
        {
            get
            {
                return length;
            }
        }

        public double Breadth
        {
            get
            {
                return breadth;
            }
        }

        public double Area
        {
            get
            {
                return Length * Breadth;
            }
        }

        public double Perimeter
        {
            get
            {
                return 2 * (Length + Breadth);
            }
        }

        public string StrValue()
        {
            return String.Format("Rectangle: {0}, {1}", Length, Breadth);
        }
    }
    
}
