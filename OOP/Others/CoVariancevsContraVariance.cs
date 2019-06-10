using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Others
{
    class CoVariancevsContraVariance
    {
        //Covariance
        void  CoVariance()
        {

            var myAnimals = new List<Giraffe>{
                new Giraffe(),
                new Giraffe()
            };
            LifeForm.PrintLifeForms(myAnimals);
            Console.ReadLine();
        }

        void ContraVariance()
        {
            var animalDelegate = ContraVarianceLifeForm.LifeForm;
            var giraffeDelegate = ContraVarianceLifeForm.Giraffe;
            giraffeDelegate = animalDelegate;
            animalDelegate(new ContraVarianceLifeForm());
            giraffeDelegate(new ContraVarianceGiraffe());
           
            Console.ReadLine();
        }
    }
    //CoVariance
    public abstract class LifeForm
    {
        //public static void PrintLifeForms(IList<LifeForm> lifeForms)
        //{
        //    foreach (var lifeForm in lifeForms)
        //    {
        //        Console.WriteLine(lifeForm.GetType().ToString());
        //    }
        //}

        public static void PrintLifeForms(IEnumerable<LifeForm> lifeForms)
        {
            foreach (var lifeForm in lifeForms)
            {
                Console.WriteLine(lifeForm.GetType().ToString());
            }
        }
    }
    public class Giraffe : LifeForm
    {

    }
    public class Zebra : LifeForm
    {

    }
    //Contravariance
    public delegate void MyAction<in T>(T obj);
    public class ContraVarianceLifeForm
    {
        public string Name { get; set; } = "LifeForm";
        public static MyAction<ContraVarianceLifeForm> LifeForm = (input) =>
        {
            Console.WriteLine("Life Form Delegate -" + input.Name);
        };
        public static MyAction<ContraVarianceGiraffe> Giraffe = (input) =>
        {
            Console.WriteLine("Giraffe Form Delegate -" + input.Name);
        };
    }
    public class ContraVarianceGiraffe : ContraVarianceLifeForm
    {
        public ContraVarianceGiraffe()
        {
            Name = "Giraffe";
        }
    }
    public class ContraVarianceZebra : ContraVarianceLifeForm
    {
        public ContraVarianceZebra()
        {
            Name = "Zebra";
        }
    }

}
