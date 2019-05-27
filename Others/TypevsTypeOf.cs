﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Others
{
    //typeof takes a type name (which you specify at compile time).
    //GetType gets the runtime type of an instance.
    //Both has Type as parent class
    class TypevsTypeOf
    {
        void Method1()
        {
            string s = "Kaushik";

            if (typeof(String) == s.GetType())
            {

            }
        }
    }
}
