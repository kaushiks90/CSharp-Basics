using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Constructor
{
    //Except static class all classes can have destructor
    //Destructor cannot have parameter or access specifier 
    //Destructor usually called for garbage collection
    //There can be only one destructor
    class Destructor
    {
    }

    sealed class SA
    {
        ~SA()
        {

        }
    }


    abstract class AA
    {
        ~AA()
        {

        }
       
    }


    static class SAA
    {
        //~SAA()
        //{

        //}
    }
    partial class PP
    {
        ~PP()
        {

        }
    }
}

