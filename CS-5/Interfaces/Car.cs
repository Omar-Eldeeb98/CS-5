using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_5.Interfaces
{
    internal class Car : Vehicle, IGround
    {
        public void backward()
        {
            Console.WriteLine("car move backward on ground");   
        }

        public void forward()
        {
            throw new NotImplementedException();
        }

        public void left()
        {
            throw new NotImplementedException();
        }

        public void right()
        {
            throw new NotImplementedException();
        }
    }
}
