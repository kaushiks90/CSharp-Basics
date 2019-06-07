using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Others
{
    //Sealed method is used to define the overriding level of a virtual method or abstract method
    //Sealed keyword is always used with override keyword.
    

    public abstract class abstractclass1
    {
        public abstract void Method2();
    }
    public class class1 : abstractclass1
    {
        public virtual void Method1()
        {
            Console.WriteLine("This is a virtual Method");
        }

        public sealed override void Method2()
        {
            Console.WriteLine("The method is sealed");
        }
    }
    public class class2 : class1
    {
        public override void Method1()
        {
            Console.WriteLine("This is a override Method");
        }

    }
    public class class3 : class1
    {
        public sealed override void Method1()
        {
            Console.WriteLine("This is a override Method");
        }

    }
    public class class4 : class3
    {
        //public sealed override void Method1()
        //{
        //    Console.WriteLine("This is a override Method");
        //}

    }
}
