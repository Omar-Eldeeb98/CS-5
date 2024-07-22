using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_5.Interfaces
{
    internal class Airplane : Vehicle, IGround, IFlay
    {
        void IGround.backward()
        {
            Console.WriteLine("airplane move backward on ground");
        }

        void IFlay.backward()
        {
            Console.WriteLine("airplane move backward on fly");
        }

        void IGround.forward()
        {
            throw new NotImplementedException();
        }

        void IFlay.forward()
        {
            throw new NotImplementedException();
        }

        void IGround.left()
        {
            throw new NotImplementedException();
        }

        void IFlay.left()
        {
            throw new NotImplementedException();
        }

        void IGround.right()
        {
            throw new NotImplementedException();
        }

        void IFlay.right()
        {
            throw new NotImplementedException();
        }
    }
}
