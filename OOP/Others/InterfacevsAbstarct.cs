using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Others
{

    //Interface
    //Interface can never inherit from classes(Sealed,static,abstract,partial)
    //Interface helps to solve the diamond problem
    //Interface methods can never have access specifiers
    //Interface is always internal
    

        //Abstract class can inherit from Abstract class,normal class,partial class,interface
        //it can have abstract as well as non abstract method
        //can have destructor, construtor, static constructor
        //can have properties
        //can be used in extension method
        //can have enum




    class InterfacevsAbstarct
    {
    }
   
    sealed class SealedClass
    {

    }
    partial class  PartialClass
    {

    }
    static class StaticClass
    {

    }
    interface IInterface
    {
       int MyProperty { get; set; }
       void Method1();
    }

    abstract class AbstractClass
    {

    }
}
