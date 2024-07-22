using CS_5.ICloneable_Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_5
{
    internal class EmployeeIdComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            Employee? employeeX = (Employee?) x;
            Employee? employeeY = (Employee?) y;

            //if(employeeX.id > employeeY.id)
            //{
            //    return 1;
            //}
            //else if(employeeX.id < employeeY.id)
            //{

            // return -1; 

            //}
            //else
            //{
            //    return 0;
            //}

            return employeeX?.id.CompareTo(employeeY?.id) ?? (employeeY is null ? 0 : -1);
        }
    }
}
