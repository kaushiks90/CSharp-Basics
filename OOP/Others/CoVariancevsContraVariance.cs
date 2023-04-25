using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Others
{
    class CoVariancevsContraVariance
    {
        void CoVariance()
        {
            Fruit f=new Fruit();
            Mango m=new Mango();

            Fruit ff = m;

            IEnumerable<Fruit> fruits = new List<Fruit>();
            IEnumerable<Mango> mangoes=new List<Mango>();

            fruits = mangoes;
        }

        void Contravariance()
        {
            Action<Fruit> FruitInfo = GetFruitInfo;
            Action<Mango> MangoInfo = GetMangoInfo;

            MangoInfo = FruitInfo;
        }

        void Invariance()
        {
            List<Fruit> fruits = new List<Fruit>();
            List<Mango> mangoes = new List<Mango>();

            //fruits = mangoes;
            //mangoes = fruits;
        }

        static void GetFruitInfo(Fruit fruit) { }

        static void GetMangoInfo(Mango mango) { }
    }
   
    class Fruit
    {

    }

    class Mango : Fruit { 
    
    }


}
