using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_5.Interfaces
{
    internal class SeriesByThree : ISeries
    {
        public int Current { get; set ; }

        public void getNext()
        {
            Current += 3;
        }

        //public void reset()
        //{
        //    Current = 0;
        //}
    }
}
