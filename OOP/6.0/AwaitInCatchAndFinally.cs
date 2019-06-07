using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OOPS._6._0
{
    class AwaitInCatchAndFinally 
    {
        public async Task<bool>  Run()
        {
            bool result = true;
            try
            {
                 result = false;
                return result;
            }
            catch(Exception ex)
            {
                await LogError(ex);
                return result;

            }
            finally
            {
                await LogResult(result);
            }

        }
        public async Task<bool> LogError(Exception exception)
        {
            //We log exception error to database for example
            return await Task.FromResult(true);
        }

        public async Task<bool> LogResult(bool result)
        {
            //We do async result logging
            return await Task.FromResult(true);
        }
    }
}
