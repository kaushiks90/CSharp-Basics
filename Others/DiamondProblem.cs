using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Others
{
    //Diamond problem is nothing but multiple inheritance of class
    //Here class D is trying to inherit from B C. 
    class A
    {
        public virtual void PrintName()
        {
            Console.WriteLine("Class A");
        }
    }

    class B : A
    {
        public override void PrintName()
        {
            Console.WriteLine("Class B");
        }
    }

    class C : A
    {
        public override void PrintName()
        {
            Console.WriteLine("Class C");
        }
    }
    //NOT WORK
    //class D : B, C
    //{

    //}

}
