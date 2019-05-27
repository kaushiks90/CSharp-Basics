using System;
using System.Collections.Generic;
using System.Text;



namespace OOPS.Classes
{
    public partial class PartialClass
    {
        private readonly int id = 0;
        //Static
        static PartialClass()
        {

        }

        //Non Static
        public PartialClass()
        {

        }

        //Non Static
        public PartialClass(int id)
        {
            this.id = id;
        }
        public void createObject()
        {
            ////Cannot create object of Abstract class it can only be inherited
            InheritedPartialClass partialClass = new InheritedPartialClass();
        }

        private partial class NestedPartialClass { }

        private partial class NestedPartialClassInheritance : PartialClass
        {

        }

        private void PassParameter(PartialClass p)
        {

        }

        public virtual int overrideProperty { get; set; }

        public virtual void overrideMethod()
        {

        }

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
        ~PartialClass()
        {

        }

    }
    public partial class PartialClassInhertedFromPartialClass : InheritedPartialClass
    {

    }

    //Static class cannot be Inherited it can only be called with className.
    //public partial class PartialClassInhertedFromPartialClass : InheritedStatiClass
    //{

    //}

    //Sealed class cannot be Inherited it can only be instantiated
    //public class PartialClassInhertedFromSealedClass : InheritedSealedClass
    //{

    //}
    public partial class PartialClassInhertedFromPartialClass : InheritedPartialClass
    {

    }
    public partial class PartialClassInhertedFromNormalClass : InheritedClass
    {

    }
    public partial class PartialClassInhertedFromInterface : IInterface
    {

    }

    public partial class partialClassProperties : NormalClass
    {
        //Static
        public static int staticPropery { get; set; }

        //abstract
        //public abstract int abstractProperty { get; set; }

        //Virtual
        public virtual int virtualPropery { get; set; }

        //Override
        public override int overrideProperty { get; set; }

    }

    public partial class PartialClassAccessFunctions : NormalClass
    {

        //public abstract void abstractMethod();
        public virtual void virtualMethod() { }

        //override and override sealed can't be in the same class

         //public override void overrideMethod() { }
       //public override sealed void overrideMethod() { }

    }


    //Interface can inherit only a interface and not class
    //interface Inherit : PartialClass
    //{

    //}

    public abstract class PartialClassAsGeneri<T> where T : InheritedPartialClass
    {
    }

    //The method can take any class as a parameter  but the class should be static
    public static class PartialClassAsExtensionMethod
    {
        public static void NewMethod(this AbstractClass ob)
        {
            Console.WriteLine("Hello I m extended method");
        }
    }
}


