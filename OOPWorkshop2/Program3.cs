using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWorkshop2
{
    class Program3
    {
        static void Main(string[] args)
        {
            Circle r = new Circle();
            Console.WriteLine(r.GetArea());
        }
    }

    class Circle
    {
        double radius;

        public Circle() : this(3.0)
        {

        }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * radius * radius;
        }

    }
    
    
    
}
