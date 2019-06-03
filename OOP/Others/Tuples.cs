using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Others
{
    //When you want to return multiple values from a method without using ref or out parameters.
    //When you want to pass multiple values to a method through a single parameter.

    //Value Tuples ?
    class Tuples
    {

        static Tuple<int, string, string> GetPerson()
        {
            return Tuple.Create(1, "Bill", "Gates");
        }

        //Tuple as a Parameter
        static void DisplayTuple(Tuple<int, string, string> person)
        {
            Console.WriteLine($"Id = { person.Item1}");
            Console.WriteLine($"First Name = { person.Item2}");
            Console.WriteLine($"Last Name = { person.Item3}");
        }

        void Mehod1()
        {
            var per = GetPerson();
            DisplayTuple(per);

            //Printing Tuple
            Console.WriteLine(per.Item1);
            Console.WriteLine(per.Item2);
        }
    }
}
