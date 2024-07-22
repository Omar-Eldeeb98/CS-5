using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_5.Interfaces
{
    internal class MyType : IMyType
    {

       public int id { get; set; }

        // object member func, none static.
        public void myFunc(int x)
        {
            Console.WriteLine($"x: {x} , id: {id}");
        }
    }
}
