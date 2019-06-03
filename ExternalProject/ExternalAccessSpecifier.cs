using System;

namespace ExternalProject
{
    public class ExternalInternalAccessSpecifier
    {
        internal int Id { get; set; }
        internal string Name { get; set; }
    }
    public class ExternalPrivateAccessSpecifier
    {
        private int Id { get; set; }
        private string Name { get; set; }
    }
    public class ExternalPublicAccessSpecifier
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class ExternalProtectedAccessSpecifier
    {
        protected int Id { get; set; }
        protected string Name { get; set; }
    }
    public class ExternalProtectedInternalAccessSpecifier
    {
        protected internal int Id { get; set; }
        protected internal string Name { get; set; }
    }
    public class ExternalPrivateProtectedAccessSpecifier
    {
        private protected int Id { get; set; }
        private protected string Name { get; set; }
    }
}
