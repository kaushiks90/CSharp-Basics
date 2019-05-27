using ExternalProject;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.AccessSpecifiers
{
    public class InternalSpecifier
    {
        internal int Id { get; set; }
        internal string Name { get; set; }
        public void MainClassMethod()
        {
            Id = 1;
            Name = "Kaushik";
        }
        public class InternalNestedClass
        {
            public void NestedClassDirectAccessMethod()
            {
                //Id = "2";
                //Name = "Kaushik";
            }
            public void NestedClassInstanceMethod()
            {
                InternalSpecifier protectedSpecifier = new InternalSpecifier
                {
                    Id = 2,
                    Name = "Kaushik"
                };
            }
        }
        public class InternalNestedClassInheritance : InternalSpecifier
        {
            public void NestedClassInheritedMethod()
            {
                Id = 2;
                Name = "Kaushik";
            }
        }
    }
    public class OutsideInternalClassInstance
    {
        private readonly InternalSpecifier privateSpecifier = new InternalSpecifier
        {
            Id = 2,
            Name = "K2"
        };
    }
    public class OutsideInternalClassInheritance : InternalSpecifier
    {
        void InheritanceMethod()
        {
            Id = 2;
            Name = "K2";
        }
    }

    public class OutsideAssemblyInternalClassInheritance : ExternalInternalAccessSpecifier
    {
        //In access due to protection level
        void ExternalInheritanceMethod()
        {
            //Id = 2;
            //Name = "K2";
        }
    }
    public class OutsideAssemblyInternalClassInstance
    {
        //In access due to protection level
        void ExternalInstanceMethod()
        {
            ExternalInternalAccessSpecifier obj = new ExternalInternalAccessSpecifier();
            //obj.Id = 1;
            //obj.Name = "k1";
        }
    }

}
