namespace OOPS._6._0
{
    internal class NullConditionalOperator
    {
        private void Method1()
        {
            //Null conditional oprator ?. or ?[]
            string[] ss = new string[3] { "K", "L", "O" };
            int? result = ss?.Length;
            string res = ss?[0];
        }
    }
}
