using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Others
{

    //Constants
    //They must have a value at compilation-time 

    //readonly
    //Must have set value, by the time constructor exits
    //Are evaluated when instance is created
    //This value can only be changed in the constructor. Can't be changed in normal functions.

    //Static readonly
    //Must have an evaluated value by the time the static constructor is done

        //Static
        //Can be accessed outside class 
    class ReadOnlyvsConst
    {
        static readonly int k;
        readonly int j;
        public const int i = 0;
        public static int ll;

        static ReadOnlyvsConst()
        {
            k = 1;
        }
        public ReadOnlyvsConst()
        {
            j = 1;
            
        }
        
    }
    class Test
    {
        void res()
        {
            ReadOnlyvsConst.ll = 0;
            ReadOnlyvsConst f = new ReadOnlyvsConst();


        }
        
    }
}
