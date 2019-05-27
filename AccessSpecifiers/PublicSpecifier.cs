using ExternalProject;

namespace OOPS.AccessSpecifiers
{
    public class PublicSpecifier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public void MainClassMethod()
        {
            Id = 1;
            Name = "Kaushik";
        }
        public class PublicNestedClass
        {
            public void NestedClassDirectAccessMethod()
            {
                //Id = 2;
                //Name = "Kaushik";
            }
            public void NestedClassInstanceMethod()
            {
                PublicSpecifier publicSpecifier = new PublicSpecifier
                {
                    Id =2,
                    Name = "Kaushik"
                };
            }
        }
        public class PublicNestedClassInheritance : PublicSpecifier
        {
            public void NestedClassInheritedMethod()
            { }
        }
    }
    public class OutsidePublicClassInstance
    {
        private readonly PublicSpecifier publicSpecifier = new PublicSpecifier
        {
            Id = 2,
            Name = "K2"
        };
    }
    public class OutsidePublicClassInheritance : PublicSpecifier
    {
        //In access due to protection level
        private void InheritanceMethod()
        {
            Id = 4;
            Name = "k4";
        }
    }

    public class OutsideAssemblyPublicClassInheritance : ExternalPublicAccessSpecifier
    {
        private void ExternalInheritanceMethod()
        {
            Id = 4;
            Name = "k4";
        }
    }
    public class OutsideAssemblyPublicClassInstance
    {
        private void ExternalInstanceMethod()
        {
            ExternalPublicAccessSpecifier obj = new ExternalPublicAccessSpecifier
            {
                Id = 1,
                Name = "k1"
            };
        }
    }

}
