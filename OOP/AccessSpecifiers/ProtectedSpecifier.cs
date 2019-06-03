using ExternalProject;

namespace OOPS.AccessSpecifiers
{
    public class ProtectedSpecifier
    {
        protected int Id { get; set; }
        protected string Name { get; set; }
        public void MainClassMethod()
        {
            Id = 1;
            Name = "Kaushik";
        }
        public class ProtectedNestedClass
        {
            public void NestedClassDirectAccessMethod()
            {
                //Id = 2;
                //Name = "Kaushik";
            }
            public void NestedClassInstanceMethod()
            {
                ProtectedSpecifier protectedSpecifier = new ProtectedSpecifier
                {
                    Id = 2,
                    Name = "Kaushik"
                };
            }
        }
        public class ProtectedNestedClassInheritance : ProtectedSpecifier
        {
            public void NestedClassInheritedMethod()
            {
                Id = 2;
                Name = "Kaushik";
            }
        }
    }
    public class OutsideProtectedClassInstance
    {
        //In access due to protection level
        private readonly ProtectedSpecifier protectedSpecifier = new ProtectedSpecifier
        {
            //Id = 2,
            //Name = "Kaushik"
        };
    }
    public class OutsideProtectedClassInheritance : ProtectedSpecifier
    {
        //In access due to protection level
        private void InheritanceMethod()
        {

            Id = 2;
            Name = "Kaushik";

        }
    }

    public class OutsideAssemblyProtectedClassInheritance : ExternalProtectedAccessSpecifier
    {
        //In access due to protection level
        private void ExternalInheritanceMethod()
        {
            Id = 2;
            Name = "Kaushik";
        }
    }
    public class OutsideAssemblyProtectedClassInstance
    {
        //In access due to protection level
        private void ExternalInstanceMethod()
        {
            ExternalProtectedAccessSpecifier obj = new ExternalProtectedAccessSpecifier
            {
                //    Id = 1,
                //Name = "k1"
            };
        }
    }

}
