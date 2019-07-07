using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Others
{
    //Disposable Pattern

    //Dispose vs Finalize
    //Gen 0,Gen1,Gen2
    //GC.Collect
    //GC.SuppressFinalize 

                       //Dispose vs FInalize
         //Finalize gets called by the GC when this object is no longer in use.
        //Dispose is just a normal method which the user of this class can call to release any resources.
        //If user forgot to call Dispose and if the class have Finalize implemented then GC will make sure it gets called.

    class GarbageCollector
    {

        //Destructor calls the finalize method .so when using destructor there is no need to call finalize explicitly
        //If Destructor is declared it won't allow us to use the finalize method (it throws compile time ambiguous error)

        //Destructor implicitly calls the Finalize method, they are technically same. 
 

        //~GarbageCollector()
        //{

        //}
        public void Finalize()
        {
            
        }
    }
    //To implement Dispose method for your custom class, you need to implement IDisposable interface. 
    //IDisposable interface expose Dispose method where code to release unmanaged resource will be written.
    //Dispose is available with those object which implements IDisposable interface.
    class GarabageCollectorDispose : IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }

}

   

