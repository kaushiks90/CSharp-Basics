using System;

//A partial method can only be created in partial classes or partial structs.
//In order to create a partial method, it must be declared first(like an abstract method), with a signature only and no definition.
//After it is declared, its body can be defined in the same component or different component of the partial class/struct .
//A partial method is implicitly private. It cannot have any other access modifier.
//A partial method can only have void return type.
namespace OOPS.Others
{
    internal class PartialMethods
    {
        public void Method()
        {
            Test1 t = new Test1();
            t.Method();
            t.Method1(1);
            Console.ReadLine();
        }
    }

    internal partial class Pa
    {
        partial void Test();

    }

    internal partial class Pa
    {
        partial void Test()
        {

        }

    }  

    public partial class Test1
    {
        public void Method()
        {
            Console.WriteLine("Method1");
        }
        partial void test1();
    }
    public partial class Test1
    {
        public void Method1(int i)
        {
            Console.WriteLine("Method2", i);
        }
        partial void test1()
        {
            Console.WriteLine("this is test1");
        }

    }
}



