using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_5.ICloneable_Interface
{
    internal class Employee : ICloneable , IComparable // this is built in interface.
    {

        public int id { get; set; }

        public string? name { get; set; }
        public decimal salary { get; set; }

        public object Clone()
        {
            return new Employee()
            {
                id = this.id,
                name = this.name,
                salary = this.salary
            };
           
           
        }

        public int CompareTo(object? obj)
        {
            Employee passedEmployee =(Employee) obj;
            if (this.salary > passedEmployee.salary)
            {
                return 1;
            }
            else if (this.salary < passedEmployee.salary) { return -1; }
            else return 0;
        }

        public override string ToString()
        {
            return $"id:{id} , name:{name} , salary:{salary:c}";
        }
    }
}
