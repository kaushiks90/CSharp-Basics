using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Constructor
{
    //The constructor which creates an object by copying variables from another object is called a copy constructor. 
    //The purpose of a copy constructor is to initialize a new instance to the values of an existing instance.
    class CopyConstructor
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public CopyConstructor(CopyConstructor c)
        {
            Id = c.Id;
            Age = c.Age;
        }
    }
}
