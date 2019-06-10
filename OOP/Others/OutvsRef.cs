using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Others
{

    class OutvsRef
    {
        public static void OutVariable(out int j)
        {
            j = 0;
            j = j + 10;
        }
        public static void RefVariable(ref int j)
        {
            j = j + 10;
        }
        public static void Variable(int i)
        {
            i = i + 10;
        }

        public static void MainMethod()
        {
            int i = 20;
            //Variable(i);   ----> 10
            //OutVariable(out i);    ----> 10
            //RefVariable(ref i);   ----> 30

            Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}
