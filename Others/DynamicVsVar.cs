using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Others
{
    //var cannot be passed as a parameter
    //var must be used inside a method
    //Value must be assigned when var is used 
    //provides intellisense

    //dynamic can be passed as a parameter
    //dynamic can be used  outside method
    //dynamic converts to its own datatype during run time
    //dynamic value can be re assigned n number of times
    //no intellisense


    class DynamicVsVar
    {
        dynamic s;
        void method()
        {
            s = 0;
            s = "Kaushik"; 
            Console.WriteLine(s);   //Prints Kaushik
        }       
       
    }
}
