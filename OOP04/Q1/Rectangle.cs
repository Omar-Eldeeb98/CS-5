using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.Q1
{
    internal class Rectangle : IRectangle
    {
        public int width { get; set ; }
        public int length { get ; set ; }
        public double area { get { return width * length; } }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle Width: {width} , Length: {length}");
            Console.WriteLine($"Rectangle Area: {area}");
        }
    }
}
