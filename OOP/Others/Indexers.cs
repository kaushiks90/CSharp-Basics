using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Others
{
    //Indexers are created with this keyword.
    //Indexer are instance member, so can't be static.
    internal class Program
    {
        class IndexerClass
        {
            private string[] names = new string[10];
            public string this[int i]
            {
                get
                {
                    return names[i];
                }
                set
                {
                    names[i] = value;
                }
            }

            public string this[int i, int j]
            {
                get
                {
                    return names[i];
                }
                set
                {
                    names[i] = value;
                }
            }
            void Method1()
            {
                IndexerClass Team = new IndexerClass();
                Team[0] = "Rocky";
                Team[1] = "Teena";
                Team[2] = "Ana";
                Team[3] = "Victoria";
                Team[4] = "Yani";
                Team[5] = "Mary";
                Team[6] = "Gomes";
                Team[7] = "Arnold";
                Team[8] = "Mike";
                Team[9] = "Peter";
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(Team[i]);
                }
                Console.ReadLine();
            }
        }
    }
}
