using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Others
{

    //The return type of the method where yield has been used, should be IEnumerable, IEnumerable<T>, IEnumerator, or IEnumerator<T>
    class Yield
    {
        static IEnumerable<int> GenerateFibonacciNumbere(int n)
        {
            for (int i = 0, j = 0, k = 1; i < n; i++)
            {
                yield return j;
                int temp = j + k;
                j = k;
                k = temp;
            }

        }

        void Method1()
        {
            foreach (var item in GenerateFibonacciNumbere(10))
            {
                Console.WriteLine(item);
            }
        }
    }

   
}
