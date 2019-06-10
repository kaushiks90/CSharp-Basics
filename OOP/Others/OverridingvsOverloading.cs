using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Others
{
    //Abstract and virtual methods can also be overridden
    //Return type overloading is impossible

    //Dynamic Polymorphism is also called as RunTime PolyMorphism (Late Binding,Method OverRiding)
    //Static PolyMorphism is also called as CompileTime PolyMorphism (Early binding ,Method overloading)

    class OverridingvsOverloading
    {
        public void overload()
        {

        }
        public void overload(int i)
        {

        }
        public void overload(float i)
        {

        }
        //Throws error because overloading  doesn't apply to the return types
        //public int overload(float i)
        //{

        //}

        public virtual void overridin(int i)
        {

        }
        public virtual void overridin(int i, int j)
        {

        }
    }
    class overidin: OverridingvsOverloading
    {
        public override void overridin(int i)
        {
           
        }
        public override void overridin(int i, int j)
        {

        }
    }

    public abstract class f {
        public abstract void overridin(int i);
        public abstract void overridin(int i,int j);
    }

    public class g : f
    {
        public override void overridin(int i)
        {
            throw new NotImplementedException();
        }

        public override void overridin(int i, int j)
        {
            throw new NotImplementedException();
        }
    }

}
