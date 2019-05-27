namespace OOPS.Others
{
    //Jagged Arrays
    //2D Arrays
    //3D Arrays
    //Array of Arrays

    internal class JaggedArrays
    {
        //A Jagged Array is an array of an array in which the length of each array index can differ.
        //Jagged array for Array
        private void JaggedArray()
        {
            int[][] intArray = new int[4][]
            {
                new int[] { 7, 9 },
                new int[] { 1, 3, 5 },
                new int[] { 1, 3, 5, 6 },
                new int[] { 1 }
        };

            //Jagged array with multidimensional
            int[][,] intMultiDimensional = new int[2][,];
            intMultiDimensional[0] = new int[,] { { 11, 12 }, { 13, 45 } };
            intMultiDimensional[1] = new int[,] { { 11, 12 } };

            //Jagged array with string
            string[][] stringarray = new string[2][]
            {
                new string[] { "Kaushik", "S" },
                new string[] { "Kaushik", "S" }
        };



        }
    }
    internal class Arrays
    {
        //Array Declaration
        int[] arr = new int[3]
        {
            3,4,5
        };

        //MultiDimensional Array   2D
        int[,] multarr = new int[2, 3]
        {
           {1,2,3},
           {4,5,6 }
        };

        //3D Array
        int[,,] threeArray = new int[2, 3, 3]
        {
            {{1,2,3},{1,2,3},{1,2,3} },{{1,2,3},{1,2,3},{1,2,3}}
        };


        //Array of Arrays
        int[][] arrayofArrays = new int[4][]
        {
             new int[]{1,2,3,4 },
             new int[]{1,2,3,4 },
             new int[]{1,2,3,4 },
             new int[]{1,2,3,4 }
        };

       //Passing as parameters
       void Method(int [,] a,int [,,]b,int [][]k)
        {

        }



    }

}

