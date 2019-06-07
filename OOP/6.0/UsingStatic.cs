using System;
using System.Collections.Generic;
using System.Text;
//Static 
using static OOPS._6._0.Greeter;
using static System.Console;

namespace OOPS._6._0
{
    class UsingStatic : IRunnable
    {
        public void Run()
        {
            Salute("Kaushik");
        }
    }
    public class Greeter
    {
        public static void Salute(string name)
        {
            WriteLine($"Hello {name}");
        }
    }
}
