using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_5.Interfaces
{
    internal interface IMyType
    {
        // -----> what we can write inside interface:

        // 1- signature for property:
        public int id { get; set; }

        // 2-  signature for method:
        public void myFunc(int x);

        // 3- default implemented method:   
        public void print()
        {
            Console.WriteLine("this is default implemented method.");
        }

    }
}
