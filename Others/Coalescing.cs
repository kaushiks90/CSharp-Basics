using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Others
{
    //Double Question mark
    //Question mark
    //Question mark with dot
    //Ternary
    class Coalescing
    {
        void Method()
        {
            //Making Value type null
            int? x = null;
            Nullable<int> y = null;

            if (x.HasValue)
            {
                Console.WriteLine("Contains value other than null",x.Value);
            }

            //Coalescing  
            //Takes the first non null value from left
            string s = null ?? "Kaushik" ?? null;

            //Ternary
            string name = s == null ? "assign k" : "assign Kaushik";


            //null-conditional operator  ?. member access, ?., or element access, ?[]
            string[] ss = new string[3]
           {
                "k","l","o"
           };
            //Checks whether ss is null then returns null else return length
            int? result = ss?.Length;

            //if ss is null return null else return ss[0]
            string res = ss?[0];
        }


    }
}
