using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Others
{
    class GenericMethods
    {
    }
    class MyGenericClass<T,U> where T:class where U:struct
    {

    }
    class MyGenericClass1<T, U> where T : IComparable<T> where U : new()
    {

    }
    class MyGenericClass2<T, U> where T : IMyInterface where U : new() 
    {

    }
    class MyGenericClass3<T, U,V> where T : Enum where U : System.Delegate where V: System.MulticastDelegate
    {

    }

    interface IMyInterface
    {

    }
}
