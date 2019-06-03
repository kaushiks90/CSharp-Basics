using System;

namespace OOPS
{
    internal struct IndexerStruct
    {

    }
    internal class Program
    {
        private static void Method1()
        {
            
                int a = 1;
                int b = 0;
                int res = a / b;
           
        }
        private static void Method2()
        {
            try
            {
                Method1();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void Main(string[] args)
        {

            Method2();
            Console.ReadLine();
        }



    }

}


//Threads
//Tpl
//stack vs heap
//singleton vs static
//shallow vs deep
//reflection
//polymorphism
//out vs ref
//Delegates events
//coVar vs contra
//collection
//Auto mapper
//async task

