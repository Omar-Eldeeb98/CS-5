using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_5.Interfaces
{
    internal interface ISeries
    {
        // signature for property.
        public int Current { get; set; }

        // signature for method.
        public void getNext();

        //public void reset();

        public void reset()
        {
            Current = 0;
        }
    }
}
