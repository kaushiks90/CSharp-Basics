using System;
using System.Collections.Generic;
using System.Text;


namespace OOPS.Classes
{
 
    public static class StaticClass
    {
        private static readonly int id = 0;
        //Static
        static StaticClass()
        {

        }

        //Static class cannot have parameter
        //static StaticClass(int a)
        //{

        //}

        //Non Static constructors are not allowed in static class
        //public StaticClass()
        //{

        //}

        //Non Static
        //public StaticClass(int id)
        //{
        //    this.id = id;
        //}

        public static void createObject()
        {
            ////Cannot create object of Static class 
            //InheritedStaticClass staticClass = new InheritedStaticClass();
        }

        private static class NestedAbstractClass { }

           //Static nestedclass cannot be inherited
        //private static class NestedAbstractClassInheritance : InheritedStaticClass
        //{

        //}

           //Static class cannot be used as a parameter
        //private static void PassParameter(StaticClass p)
        //{

        //}


            //Static class cannot have virtual
        //public static virtual int overrideProperty { get; set; }

        //public static virtual void overrideMethod()
        //{

        //}

        public struct National
        {
            public int Past { get; set; }

        }

        private static void EnumMethod()
        {
            int x = (int)CardSuit.Clubs;
        }


        private static int PrivateProperty { get; set; }
        public static int PubliProperty { get; set; }

                //static class cannot contain 
        //protected static int ProtetedProperty { get; set; }
        //protected internal static int ProtectedInternalMyProperty { get; set; }
        //private  protected static int PrivateProtectedProperty { get; set; }

        //The destructor automatically invoked by garbage collector whenever the class objects that are no longer needed in application.
        //Static class cannot contain destructor
        //~StaticClass()
        //{

        //}

    }
    //Static class cannot be inherited
    //public static class staticClassInhertedFromAbstractClass : InheritedAbstractClass
    //{

    //}   
    //public static class staticClassInhertedFromStaticClass : InheritedStaticClass
    //{

    //}   
    //public static class staticClassInhertedFromSealedClass : InheritedSealedClass
    //{

    //}
    //public static class staticClassInhertedFromPartialClass : InheritedPartialClass
    //{

    //}
    //public static class staticClassInhertedFromNormalClass : InheritedClass
    //{

    //}
    //public static class staticClassInhertedFromInterface : IInterface
    //{

    //}

    public static class staticClassProperties 
    {
        //Static
        public static int staticPropery { get; set; }

        //abstract
        //public abstract int abstractProperty { get; set; }

        //Virtual
        //public virtual int virtualPropery { get; set; }

        //Override
       // public override int overrideProperty { get; set; }

    }

    public static class staticClassAccessFunctions 
    {

        //public abstract void abstractMethod();
        //public virtual void virtualMethod() { }

        //override and override sealed can't be in the same class

         //public override void overrideMethod() { }
        // override sealed void overrideMethod() { }

    }


    //Interface can inherit only a interface and not class
    //interface Inherit : StaticClass
    //{

    //}

    public static class StaticClassAsGeneric<T> where T : NormalClass
    {
    }

    //The method can take any class as a parameter  but the class should be static
    public static class StaticClassAsExtensionMethod
    {
        public static void NewMethod(this NormalClass ob)
        {
            Console.WriteLine("Hello I m extended method");
        }
    }
}


