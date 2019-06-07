using System;

namespace OOPS._6._0
{
    internal class StringInterpolation
    {
        private void Method1()
        {
            Action<int> actiondelegate = (i) =>
              {
                  Console.WriteLine($"The value of i is {i}");
              };
        }
    }
}
