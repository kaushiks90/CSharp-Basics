using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Others
{
    
    internal class Delegates
    {
        private delegate void displayDelegate();
        private delegate int displayDelegatewithint();
        private delegate int displayDelegatewithParameters(int x);
        private delegate void displayMultiCastDelegate();
        private delegate int displayMultiCastDelegatewithint();
        private delegate int displayMultiCastDelegatewithintParameter(int x);
        public static void Methods()
        {
            displayDelegate d1 = DelegatewithVoid.Method1;
            displayDelegate d2 = DelegatewithVoid.Method2;
            displayDelegate d3 = DelegatewithVoid.Method3;
            //d1();
            //d2();
            //d3();

            displayDelegatewithint di1 = DelegatewithReturnInt.Method1;
            displayDelegatewithint di2 = DelegatewithReturnInt.Method2;
            displayDelegatewithint di3 = DelegatewithReturnInt.Method3;
            //Console.WriteLine(di1());
            //Console.WriteLine(di2());
            //Console.WriteLine(di3());

            displayDelegatewithParameters dp1 = DelegatewithParameters.Method1;
            displayDelegatewithParameters dp2 = DelegatewithParameters.Method2;
            displayDelegatewithParameters dp3 = DelegatewithParameters.Method3;
            //Console.WriteLine(dp1(1));
            //Console.WriteLine(dp1(2));
            //Console.WriteLine(dp1(3));


            //MultiCast Delegate
            displayMultiCastDelegate dm1 = DelegatewithVoid.Method1;
            dm1 += DelegatewithVoid.Method2;
            dm1 += DelegatewithVoid.Method3;
            //dm1();

            //This will return only the last value
            displayMultiCastDelegatewithint dm2 = DelegatewithReturnInt.Method1;
            dm2 += DelegatewithReturnInt.Method2;
            dm2 += DelegatewithReturnInt.Method3;
            //Console.WriteLine(dm2());

            displayMultiCastDelegatewithintParameter dm3 = DelegatewithParameters.Method1;
            dm3 += DelegatewithParameters.Method2;
            dm3 += DelegatewithParameters.Method3;
            //Console.WriteLine(dm3(1));

            //Custom Delegate
            //Action delegate  does not return any value
            Action actdel = DelegatewithVoid.Method1;
            actdel += DelegatewithVoid.Method2;
            actdel += DelegatewithVoid.Method3;
            //actdel();

            //Func Delegate
            Func<int> funcdel = DelegatewithReturnInt.Method1;
            //Console.WriteLine(funcdel()); 

            //Func Delegate with Parameter
            Func<int, int> funcdelParam = DelegatewithParameters.Method1;
            //Console.WriteLine(funcdelParam(1));

            Func<int, int> rr = (i) =>
            {
                return i;
            };
            //Console.WriteLine(rr(1));


            //Predicate Returns true or false
            int res = DelegatewithReturnInt.Method1();
            Predicate<int> predicateDel = PredicateTestMethod;
            //Console.WriteLine(predicateDel(1));


            //Delegate as a parameter
            Action<int> Actionint = DelegatewithReturnInt.Method1;
            DelegateAsaParameter.Method1(Actionint);

            Func<int, int> func1 = DelegatewithParameters.Method1;
            DelegateAsaParameter.Method2(func1);

            Predicate<int> pred1 = PredicateTestMethod;
            DelegateAsaParameter.Method3(pred1);


            Console.ReadLine();
        }

        private static bool PredicateTestMethod(int i)
        {
            return i == 1 ? true : false;
        }
    }
    internal class DelegateAsaParameter
    {
        public static void Method1(Action<int> m1)
        {
            //m1(1);        
        }
        public static void Method2(Func<int, int> m1)
        {
            //Console.WriteLine(m1(20));

        }
        public static void Method3(Predicate<int> m1)
        {
            Console.WriteLine(m1(2));

        }
    }

    internal class DelegatewithVoid
    {

        public static void Method1()
        {
            Console.WriteLine("This is method1");
        }
        public static void Method2()
        {
            Console.WriteLine("This is method2");
        }
        public static void Method3()
        {
            Console.WriteLine("This is method3");
        }
    }



    internal class DelegatewithReturnInt
    {
        public static void Method1(int x)
        {
            Console.WriteLine("nothing");
        }

        public static int Method1()
        {
            return 1;
        }
        public static int Method2()
        {
            return 2;
        }
        public static int Method3()
        {
            return 3;
        }
    }

    internal class DelegatewithParameters
    {

        public static int Method1(int x)
        {
            return x;
        }
        public static int Method2(int x)
        {
            return x;
        }
        public static int Method3(int x)
        {
            return x;
        }
    }

}

