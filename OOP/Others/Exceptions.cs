using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Others
{
    //Try,catch,finally inside try is possible
    //Try,catch,finally inside catch is possible
    //Try,catch,finally inside finally is possible
    //Try finally is also possible


        //Throw ex will not have the  complete stacktrace details ,it will only have the recent error 
        //Throw will have complete error details and will preserve the errors


        //Cant have two catch block with same exception 
    class Exceptions
    {
        void Method()
        {
            try
            {

            }
            finally
            {

            }
        }
         void Method1()
        {

            int a = 1;
            int b = 0;
            int res = a / b;

        }
          void Method2()
        {
            try
            {
                Method1();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        void Method3()
        {
            //try
            //{

            //}
            //catch (NullReferenceException)
            //{

            //    throw;
            //}
            //catch (NullReferenceException)
            //{

            //    throw;
            //}
        
            try
            {
                try
                {

                }
                catch (Exception)
                {

                    throw;
                }
            }
            
            catch (Exception)
            {

                try
                {

                }
                catch (Exception)
                {

                    throw;
                }
                finally { }
            }
            finally{
                try
                {

                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {

                }
            }
        }
    }
}
