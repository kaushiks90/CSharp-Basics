﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Others
{

    //Struct can't inherit class it can inherit from interface
    //struct cannot have parameterless constructor
    //Can have static constructor cannot have destructor
    //Structure members cannot be specified as abstract, virtual, or protected.
    //Struct can be private,internal and public

    class Struct
    {
    }


   internal struct Employee1
    {
        public int EmpId;
       
        static Employee1()
        {

        }
        public Employee1(int empid)
        {
            this.EmpId = empid;
        }
        void m1()
        {
            int i = 0;
        }
    }

    partial struct partialStruct
    {
        partial void test();
    }
    partial struct partialStruct: i1
    {
        partial void test()
        {
            Console.WriteLine("This is partial method");
        }
    }
    interface i1
    {

    }
}
