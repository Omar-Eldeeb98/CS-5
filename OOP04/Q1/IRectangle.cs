using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.Q1
{
    public interface IRectangle : IShape
    {
        public int width { get; set; }
        public int length { get; set; }

    }
}
