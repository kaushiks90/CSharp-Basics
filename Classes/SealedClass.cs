using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Classes
{
  
    public sealed class SealedClass
    {
        private readonly int id = 0;
        //Static
        static SealedClass()
        {

        }

        //Non Static
        public SealedClass()
        {

        }

        //Non Static
        public SealedClass(int id)
        {
            this.id = id;
        }
        public void createObject()
        {
          
            InheritedSealedClass sealedClass = new InheritedSealedClass();
        }

        private sealed class NestedSealedClass { }

        private sealed class NestedSealedClassInheritance : NormalClass
        {

        }

        private void PassParameter(SealedClass p)
        {

        }

        //Virtual member and virtual function cannot be declared inside sealed class
        //public virtual int overrideProperty { get; set; }

        //public virtual void overrideMethod()
        //{

        //}

        public struct National
        {
            public int Past { get; set; }

        }

        private void EnumMethod()
        {
            int x = (int)CardSuit.Clubs;
        }


        private int PrivateProperty { get; set; }
        public int PubliProperty { get; set; }
        protected int ProtetedProperty { get; set; }
        protected internal int ProtectedInternalMyProperty { get; set; }
        private protected int PrivateProtectedProperty { get; set; }

        //The destructor automatically invoked by garbage collector whenever the class objects that are no longer needed in application.
        ~SealedClass()
        {

        }

    }
    public sealed class SealedClassInhertedFromAbstractClass: InheritedAbstractClass
    {

    }

    //Static class cannot be Inherited it can only be called with className.
    //public sealed class SealedClassInhertedFromStaticClass : InheritedStaticClass
    //{

    //}

    //Sealed class cannot be Inherited it can only be instantiated
    //public sealed class SealedClassInhertedFromSealedClass : InheritedSealedClass
    //{

    //}
    public sealed class SealedClassInhertedFromPartialClass : InheritedPartialClass
    {

    }
    public sealed class SealedClassInhertedFromNormalClass : InheritedClass
    {

    }
    public sealed class SealedClassInhertedFromInterface : IInterface
    {

    }

    public abstract class SealedClassProperties : NormalClass
    {
        //Static
        public static int staticPropery { get; set; }

        //abstract
        public abstract int abstractProperty { get; set; }

        //Virtual
        public virtual int virtualPropery { get; set; }

        //Override
        public override int overrideProperty { get; set; }

    }

    public sealed class SealedClassAccessFunctions : NormalClass
    {

        //public abstract void abstractMethod();
        //public virtual void virtualMethod() { }

        //override and override sealed can't be in the same class

        // public override void overrideMethod() { }
        //public override sealed void overrideMethod() { }

    }


    //Interface can inherit only a interface and not class
    //interface Inherit : SealedClass
    //{

    //}

    public sealed class SealedClassAsGeneri<T> where T : NormalClass
    {
    }

    //The method can take any class as a parameter  but the class should be static
    public static class SealedClassAsExtensionMethod
    {
        public static void NewMethod(this SealedClass ob)
        {
            Console.WriteLine("Hello I m extended method");
        }
    }
}

