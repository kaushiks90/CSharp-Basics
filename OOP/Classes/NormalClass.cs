using System;

namespace OOPS.Classes
{
    public class NormalClass
    {
        int id = 0;
        //Static
        static NormalClass()
        {

        }

        //Non Static
        public NormalClass()
        {

        }

        //Non Static
        public NormalClass(int id)
        {
            this.id = id;
        }
        public void createObject()
        {
            InheritedClass inheritedClass = new InheritedClass();
        }
       
        class NestedClass { }

        class NestedClassInheritance:NormalClass
        {

        }
        void PassParameter(NormalClass p)
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

        void EnumMethod()
        {
            int x = (int)CardSuit.Clubs;
        }


        private int PrivateProperty { get; set; }
        public int PubliProperty { get; set; }
        protected int ProtetedProperty { get; set; }
        protected internal int ProtectedInternalMyProperty { get; set; }
        private protected int PrivateProtectedProperty { get; set; }

        //The destructor automatically invoked by garbage collector whenever the class objects that are no longer needed in application.
        ~NormalClass()
        {

        }

    }
    public class NormalClassInhertedFromAbstractClass: InheritedAbstractClass
    {

    }

    //Static class cannot be Inherited it can only be called with className.
    //public class NormalClassInhertedFromStaticClass: InheritedStaticClass
    //{

    //}

    //Sealed class cannot be Inherited it can only be instantiated
    //public class NormalClassInhertedFromSealedClass: InheritedSealedClass
    //{

    //}
    public class NormalClassInhertedFromPartialClass: InheritedPartialClass
    {

    }
    public class NormalClassInhertedFromNormalClass: InheritedClass
    {

    }
    public class NormalClassInhertedFromInterface: IInterface
    {

    }

    public class NormalClassProperties: NormalClass
    {
        //Static
        public static int staticPropery { get; set; }

        //Abstract
        //Abstract property can be present only inside abstract class
        //public abstract int abstractProperty { get; set; }

        //Virtual
        public virtual int virtualPropery { get; set; }

        //Override
        public override int  overrideProperty { get; set; }

    }
   
    public class NormalClassAccessFunctions: NormalClass
    {
        //Abstract method can be present only inside abstract class
        //public abstract void abstractMethod();
        public virtual void virtualMethod() { }

        //override and override sealed can't be in the same class

       // public override void overrideMethod() { }
        //public override sealed void overrideMethod() { }
        
    }

    //Interface can inherit only a interface and not class
    //interface Inherit: NormalClass
    //{

    //}  

    public class NormalClassAsGeneri<T> where T:InheritedClass
    {
    }

    //The method can take any class as a parameter  but the class should be static
    public static class NormalClassAsExtensionMethod
    {
        public static void NewMethod(this NormalClass ob)
        {
            Console.WriteLine("Hello I m extended method");
        }
    }


}
