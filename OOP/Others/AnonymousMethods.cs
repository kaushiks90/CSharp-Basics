using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Others
{
    //As the name suggests, an anonymous method is a method without a name. 
    //Anonymous methods in C# can be defined using the delegate keyword and can be assigned to a variable of delegate type
    class AnonymousMethods
    {
        delegate void PrintDelegate(int value);
        delegate void PrintDelegate1();
        public void Method1()
        {
            //Type 1
            PrintDelegate p1 = (i) =>
            {
                Console.WriteLine(i);
            };

            //Type 2
            PrintDelegate p2 = delegate (int value)
            {
                Console.WriteLine(value);
            };

            //Type 3
            Action<int> p3 = (i) =>
            {
                Console.WriteLine(i);
            };

            p1(1);
            p2(2);
            p3(3);
        }
        public void Method2()
        {
            //Type 1
            PrintDelegate1 p1 = () =>
            {
                Console.WriteLine("Method2");

            };

            //Type 2
            PrintDelegate1 p2 = delegate ()
            {
                Console.WriteLine("Method2");

            };
            //Type3
            Action p3 = () =>
            {
                Console.WriteLine("Method2");
            };

            p1();
            p2();
            p3();

        }
    }
    internal class resultClass {
        void Method1()
        {
            AnonymousMethods a = new AnonymousMethods();
            a.Method2();
        }       
    }

}
