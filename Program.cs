using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    internal class Program
    {
   
        public static void Main(string[] args)
        {
            foreach (var item in GenerateFibonacciNumbere(10))
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }  
        
        static IEnumerable<int>GenerateFibonacciNumbere(int n)
        {
            for (int i = 0,j=0,k=1; i < n; i++)
            {
                yield return j;
                int temp = j + k;
                j = k;
                k = temp;
            }

        }
        
    }
   
}


//Yield
//Up vs downcasting
//Threads
//Tpl
//stack vs heap
//singleton vs static
//shallow vs deep
//reflection
//polymorphism
//out vs ref
//interface vs abstract
//indexers
//Garbage collector
//Exception
//Delegates events
//coVar vs contra
//collection
//Auto mapper
//async task

