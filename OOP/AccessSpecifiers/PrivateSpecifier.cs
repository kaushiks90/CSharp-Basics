using ExternalProject;

namespace OOPS.AccessSpecifiers
{
    public class PrivateSpecifier
    {
        private int id { get; set; }
        private string name { get; set; }
        public void MainClassMethod()
        {
            id = 1;
            name = "Kaushik";
        }

        private class PrivateNestedClass
        {
            
            public void NestedClassDirectAccessMethod()
            {
                //Unable to do this gives compile time error
                //id = 2;
                //name = "Kaushik1";
            }
            public void NestedClassInstanceMethod()
            {
                PrivateSpecifier privateSpecifier = new PrivateSpecifier
                {
                    id = 2,
                    name = "K2"
                };


            }
        }
        private class PrivateNestedClassInherited : PrivateSpecifier
        {
            public void NestedClassInheritedMethod()
            {
                id = 3;
                name = "k3";
            }
        }
    }
    public class OutsidePrivateClassInstance
    {
        //In access due to protection level
        private readonly PrivateSpecifier privateSpecifier = new PrivateSpecifier
        {
            //id = 2,
            //name = "K2"
        };
    }
    public class OutsidePrivateClassInheritance: PrivateSpecifier
    {
        //In access due to protection level
        void InheritanceMethod()
        {
            //id = 4;
            //name = "k4";
        }
    }

    public class OutsideAssemblyPrivateClassInheritance : ExternalPrivateAccessSpecifier
    {
        //In access due to protection level
        void ExternalInheritanceMethod()
        {
            //id = 4;
            //name = "k4";
        }
    }
    public class OutsideAssemblyPrivateClassInstance 
    {
        //In access due to protection level
        void ExternalInstanceMethod()
        {
            ExternalPrivateAccessSpecifier obj = new ExternalPrivateAccessSpecifier();
            //obj.Id = 1;
            //obj.Name="k1"
        }
    }
}
