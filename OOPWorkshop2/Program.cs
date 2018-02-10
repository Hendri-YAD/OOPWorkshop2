using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWorkshop2
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle r = new Triangle(6, 8 ,10);
            Console.WriteLine(r.StrValue());
            Console.WriteLine(r.Perimeter);
            Console.WriteLine(r.Area);
            Console.WriteLine(r.IsRightAngle);
            r.side1 = 7;
            Console.WriteLine(r.StrValue());
        }
    }

    class Triangle
    {
        double s1, s2, s3;

        public Triangle(double a, double b, double c)
        {
            s1 = a;
            s2 = b;
            s3 = c;        
        }

        public double side1 //example of a property
        {
            get
            {
                return s1;
            }

            set
            {
                s1 = value;
            }
        }
        public double side2
        {
            get
            {
                return s2;
            }

            set
            {
                s2 = value;
            }
        }
        public double side3
        {
            get
            {
                return s3;
            }

            set
            {
                s3 = value;
            }
        }

        public double Area
        {
            get
            {
                double s = (s1 + s2 + s3) / 2;
                double area = Math.Sqrt(s * (s-s1) * (s-s2) * (s-s3));
                return area;
            }
        }

        public double Perimeter
        {
            get
            {
                return s1 + s2 + s3;
            }
        }

        public bool IsRightAngle
        {
            get
            {
                return (s1 * s1 + s2 * s2) == (s3 * s3);
            }
        }

        public string StrValue()
        {
            return String.Format("Triangle: {0},{1},{2}", side1, side2, side3);
        }

    }
    
}
