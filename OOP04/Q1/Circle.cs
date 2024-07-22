using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.Q1
{
    internal class Circle : ICircle
    {
        public double radius { get ; set ; }
        public double area { get { return Math.PI * radius * radius; } }

        public void DisplayShapeInfo()
        {
            Console.WriteLine( $"Circle Radius: {radius}");
            Console.WriteLine($"Circle Area: {area}");
        }
    }
}
