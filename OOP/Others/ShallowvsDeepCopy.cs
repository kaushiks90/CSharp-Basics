using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Others
{
    class ShallowvsDeepCopy
    {
        void MainMethod()
        {
             //Shallow Copy
            ShallowCopy obj = new ShallowCopy();
            obj.a = 10;
            ShallowCopy obj1 = new ShallowCopy();
            obj1 = obj;
            Console.WriteLine("{0} {1}",obj1.a,obj.a);   // 10,10
            obj1.a = 5;
            Console.WriteLine("{0} {1}", obj1.a, obj.a); //5,5

            //Deep Copy
            DeepCopy d = new DeepCopy();
            d.a = 10;
            DeepCopy d1 = new DeepCopy();
            d1.a = d.a;
            Console.WriteLine("{0} {1}", d1.a, d.a);   // 10,10
            d1.a = 5;
            Console.WriteLine("{0} {1}", d1.a, d.a); //5,10
            Console.ReadLine();
        }
    }
    class ShallowCopy
    {
        public int a = 10;
    }
    class DeepCopy
    {
        public int a = 10;
    }
}
