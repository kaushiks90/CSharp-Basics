using System;

namespace OOPS.Classes
{
    public abstract class AbstractClass
    {
        private readonly int id = 0;
        //Static
        static AbstractClass()
        {

        }

        //Non Static
        public AbstractClass()
        {

        }

        //Non Static
        public AbstractClass(int id)
        {
            this.id = id;
        }
        public void createObject()
        {
            ////Cannot create object of Abstract class it can only be inherited
            //InheritedAbstractClass abstractClass = new InheritedAbstractClass();
        }

        private abstract class NestedAbstractClass { }

        private abstract class NestedAbstractClassInheritance : AbstractClass
        {

        }

        private void PassParameter(AbstractClass p)
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
        ~AbstractClass()
        {

        }

    }
    public class AbstractClassInhertedFromAbstractClass : InheritedAbstractClass
    {

    }

    //Static class cannot be Inherited it can only be called with className.
    //public class AbstractClassInhertedFromStaticClass : InheritedStaticClass
    //{

    //}

    //Sealed class cannot be Inherited it can only be instantiated
    //public class AbstractClassInhertedFromSealedClass : InheritedSealedClass
    //{

    //}
    public abstract class AbstractClassInhertedFromPartialClass : InheritedPartialClass
    {

    }
    public abstract class AbstractClassInhertedFromNormalClass : InheritedClass
    {

    }
    public abstract class AbstractClassInhertedFromInterface : IInterface
    {

    }

    public abstract class AbstractClassProperties : NormalClass
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

    public abstract class AbstractClassAccessFunctions : NormalClass
    {
        
        public abstract void abstractMethod();
        public virtual void virtualMethod() { }

        //override and override sealed can't be in the same class

        // public override void overrideMethod() { }
        //public override sealed void overrideMethod() { }

    }


    //Interface can inherit only a interface and not class
    //interface Inherit : AbstractClass
    //{

    //}

    public abstract class AbstractClassAsGeneri<T> where T : InheritedAbstractClass
    {
    }

    //The method can take any class as a parameter  but the class should be static
    public static class AbstractClassAsExtensionMethod
    {
        public static void NewMethod(this AbstractClass ob)
        {
            Console.WriteLine("Hello I m extended method");
        }
    }
}


