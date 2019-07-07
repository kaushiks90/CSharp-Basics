using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Others
{
 
    //Enum can be declared inside and also outside class
    //Flags in Enum should always power of 2
    //it can return 2 values
    class EnumsvsFlags
    {
        enum WeekDays
        {
            Monday = 0,
            Tuesday = 1,
            Wednesday = 2,
            Thursday = 3,
            Friday = 4,
            Saturday = 5,
            Sunday = 6
        }

        [Flags] enum SuitsFlags { Spades = 1, Clubs = 2, Diamonds = 4, Hearts = 8 }

        void Method1()
        {

           
            string s = nameof(WeekDays.Monday);   
            int x = (int)WeekDays.Friday;
            Console.WriteLine(x);  //4
            Console.WriteLine(s);  //Monday


            var str2 = (SuitsFlags.Spades | SuitsFlags.Diamonds).ToString();  // "Spades, Diamonds"
            var str3 = (WeekDays.Monday | WeekDays.Thursday).ToString();

        }
     

    }
}
