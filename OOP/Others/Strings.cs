using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Others
{

    //string vs String
    //string is an alias for the String class in .NET framework
    //The only tiny difference is that if you use the String class, you need to import the System namespace on top of your file,whereas you don’t have to do this when using the string keyword.

    //convert.ToString vs .toString
    //"Convert" function handles NULLS, while "i.ToString()" does not it will throw a NULL reference exception error.


    //Mutable vs Immutable
    //String Vs StringBuilder
    //String is immutable that is values cannot be changed and if changed it points to diff memory location
    //In plane english mutable means change(stringbuilder) immutable means cannot change(string)


    class Strings
    {

        //Return not equal
       void str()
        {
            string s = "ss";
            string ss = s;
            ss += "user";
            if (object.ReferenceEquals(s, ss))
            {
                Console.WriteLine("equal");
            }
            else
            {
                Console.WriteLine("not equal");
            }
            Console.ReadLine();
        }

        //Returns equal
        void Stringbuilder()
        {
            StringBuilder s = new StringBuilder("ss");
            StringBuilder ss = s;
            ss.Append("user");
            if (object.ReferenceEquals(s, ss))
            {
                Console.WriteLine("equal");
            }
            else
            {
                Console.WriteLine("not equal");
            }
        }
    }
}
