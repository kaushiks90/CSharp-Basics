using ExternalProject;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.AccessSpecifiers
{
    public class PrivateProtectedSpecifier
    {
        private protected int Id { get; set; }
        private protected string Name { get; set; }
        public void MainClassMethod()
        {
            Id = 1;
            Name = "Kaushik";
        }
        public class PrivateProtectedInternalNestedClass
        {
            public void NestedClassDirectAccessMethod()
            {
                //Id = "2";
                //Name = "Kaushik";
            }
            public void NestedClassInstanceMethod()
            {
                PrivateProtectedSpecifier protectedSpecifier = new PrivateProtectedSpecifier
                {
                    Id = 2,
                    Name = "Kaushik"
                };
                 
            }
        }
        public class PrivateProtectedNestedClassInheritance : PrivateProtectedSpecifier
        {
            public void NestedClassInheritedMethod()
            {
                Id = 2;
                Name = "Kaushik";
            }
        }
    }
    public class OutsidePrivateProtectedClassInstance
    {
        //In access due to protection level
        private readonly PrivateProtectedSpecifier privateSpecifier = new PrivateProtectedSpecifier
        {
            //Id = 2,
            //Name = "K2"
        };
    }
    public class OutsidePrivateProtectedClassInheritance : PrivateProtectedSpecifier
    {
        //In access due to protection level
        void InheritanceMethod()
        {
            Id = 4;
            Name = "k4";
        }
    }

    public class OutsideAssemblyPrivateProtectedClassInheritance : ExternalPrivateProtectedAccessSpecifier
    {
        //In access due to protection level
        void ExternalInheritanceMethod()
        {
            //Id = 4;
            //Name = "k4";
        }
    }
    public class OutsideAssemblyPrivateProtectedClassInstance
    {
        //In access due to protection level
        void ExternalInstanceMethod()
        {
            ExternalPrivateProtectedAccessSpecifier obj = new ExternalPrivateProtectedAccessSpecifier();
            //obj.Id = 1;
            //obj.Name = "k1";
        }
    }

}
