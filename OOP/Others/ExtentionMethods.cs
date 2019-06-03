using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Others
{
    //It is a static method.
    //It must be located in a static class.
    //It uses the "this" keyword as the first parameter with a type in .Net and this method will called by a given type instance on the client side.
    public class Class1
    {
        public string Display()
        {
            return ("I m in Display");
        }

        public string Print()
        {
            return ("I m in Print");
        }

        void method1()
        {
            Class1 ccd = new Class1();
            ccd.NewMethod();

            string s = "Kaushik";
            s.NewMethod1("s");
        }
        
    }
    public static  class ExtentionMethods
    {
        public static void NewMethod(this Class1 ob)
        {
            Console.WriteLine("Hello I m extended method");
        }

        public static string NewMethod1(this string ob,string s)
        {
            return ob + " "+s;
        }
    }
}
