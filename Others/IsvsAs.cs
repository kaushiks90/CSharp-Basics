using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Others
{
    //Is -->string is object  (return true or false)
   //As -->convert string as object 
    class IsvsAs
    {
        string s = "Kaushik";
        void Method()
        {
            if(s is String)
            {
                Console.WriteLine("Is Key word is working");
            }
            object a = s as object;
        }
    }
}
