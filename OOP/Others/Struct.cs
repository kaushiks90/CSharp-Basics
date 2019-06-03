using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Others
{

    //Struct can't inherit class it can inherit from interface
    //struct cannot have parameterless constructor
    //Can have static constructor
    //Structure members cannot be specified as abstract, virtual, or protected.
    //Struct can be private,internal and public

    class Struct
    {
    }


   internal struct Employee
    {
        public int EmpId;
       
        static Employee()
        {

        }
        public Employee(int empid)
        {
            this.EmpId = empid;
        }
        void m1()
        {
            int i = 0;
        }
    }
}
