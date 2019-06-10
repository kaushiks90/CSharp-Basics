using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Constructor
{
    //All classes can have static constructor
    //A class can have only 1 static constructor
    //Static constructor are parameterless
    //Static constructor will be called first before any other constructor
    //Static constructor will be called only once
    //Once a type initializer has failed once, it is never retried. 
    //The type is dead for the lifetime of the AppDomain.

    class StaticConstructor
    {
        void MaiMethod()
        {
            for (int i = 0; i < 5; i++)
            {
                try
                {
                    Bang.Foo();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.GetType().Name);
                }
            }
            Console.ReadLine();
        }
      
    }

    abstract class A
    {
        static A()
        {

        }
    }
    sealed class S
    {
        static S()
        {

        }
       
    }
    partial class P
    {
        static P()
        {

        }
    }
    static class St
    {
        static St()
        {

        }
    }

    public sealed class Bang
    {
        static Bang()
        {
            Console.WriteLine("In static constructor");
            throw new Exception("Bang!");
        }
        public Bang()
        {
            Console.WriteLine("Constructor");
        }

        public static void Foo() { }
    }
}
