using ExternalProject;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.AccessSpecifiers
{
   public class ProtectedInternalSpecifier
    {
        protected internal int Id { get; set; }
        protected internal string Name { get; set; }
        public void MainClassMethod()
        {
            Id = 1;
            Name = "Kaushik";
        }
        public class ProtectedInternalNestedClass
        {
            public void NestedClassDirectAccessMethod()
            {
                //Id = "2";
                //Name = "Kaushik";
            }
            public void NestedClassInstanceMethod()
            {
                ProtectedInternalSpecifier protectedSpecifier = new ProtectedInternalSpecifier
                {
                    Id = 2,
                    Name = "Kaushik"
                };
            }
        }
        public class ProtectedInternalNestedClassInheritance : ProtectedInternalSpecifier
        {
            public void NestedClassInheritedMethod()
            {
                Id = 2;
                Name = "Kaushik";
            }
        }
    }
    public class OutsideProtectedInternalClassInstance
    {
        //In access due to protection level
        private readonly ProtectedInternalSpecifier privateSpecifier = new ProtectedInternalSpecifier
        {
            Id = 2,
            Name = "K2"
        };
    }
    public class OutsideProtectedInternalClassInheritance : ProtectedInternalSpecifier
    {
        //In access due to protection level
        void InheritanceMethod()
        {
            Id = 2;
            Name = "K2";
        }
    }

    public class OutsideAssemblyProtectedInternalClassInheritance : ExternalProtectedInternalAccessSpecifier
    {
        //In access due to protection level
        void ExternalInheritanceMethod()
        {
            Id = 2;
            Name = "K2";
        }
    }
    public class OutsideAssemblyProtectedInternalClassInstance
    {
        //In access due to protection level
        void ExternalInstanceMethod()
        {
            ExternalProtectedInternalAccessSpecifier obj = new ExternalProtectedInternalAccessSpecifier();
            //obj.Id = 1;
            //obj.Name = "k1";
        }
    }

}

