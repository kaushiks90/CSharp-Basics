using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Constructor
{
    //Parameter constructor can be overloaded
    //If a class containing parameter constructor is inherited then the value needs to be passed to the parameter constructor
    public class ParameterizedConstructor
    {
       
        public ParameterizedConstructor(int i)
        {

        }
        public ParameterizedConstructor(int i,int j)
        {

        }
    }
    public class a: ParameterizedConstructor
    {
        public a():base(1)
        {

        }
    }
 
}
