using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Others
{
    //Named Parameter 
    //Optional Parameter
    class NamedParameters
    {
        public static int AddNumber(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        void Test()
        {
            NamedParameters.AddNumber(firstNumber: 1, secondNumber: 2);
        }
    }
    public class OptionalParameters
    {
        public int AddNumber(int firstNumber, int secondNumber=0 )
        {
            return firstNumber + secondNumber;
        }
        public void MainMethod()
        {
            AddNumber(12);
        }
    }

}
