using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Others
{
    class BoxingvsUnBoxing
    {
       void Method()
        {
            //Boxing
            int i = 12;
            object box = i;

            //UnBoxing
            object unbox = 12;
            int j = (int)unbox;
        }


    }
}
