namespace OOPS.Constructor
{

    //If a class is having a private constructor it cannot be inherited or instantiated
    //If a nested class present inside a class which contains private constructor then it can be instantiated and inherited 
    //Used for creating singleton pattern
    //If a class with private constructor is sealed then it cannot be inherited or instantiated 
    internal class PrivateConstructor
    {
        private PrivateConstructor()
        {

        }
        private PrivateConstructor(double x)
        {

        }
        private PrivateConstructor(int x)
        {

        }

        public class d
        {

        }
    }

    internal class NormalClass
    {
        private readonly PrivateConstructor.d f = new PrivateConstructor.d();
    }
    internal class NormalClass1: PrivateConstructor.d
    {
        
    }
}
