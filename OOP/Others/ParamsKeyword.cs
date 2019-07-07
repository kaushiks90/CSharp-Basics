namespace OOPS.Others
{

    //Params can be 1D array
    //Params can be array of arrays 
    //Params cannot be 2D or 3 d arrays
    internal class ParamsKeyword
    {
        private readonly int[] arr = new int[3]
        {
            1,2,3
        };
        private readonly int[,] twodarray = new int[2, 2]{
            {1,2 },{2,3}
            };
        private readonly int[][] arrayofArrays = new int[4][]
        {
             new int[]{1,2,3,4 },
             new int[]{1,2,3,4 },
             new int[]{1,2,3,4 },
             new int[]{1,2,3,4 }
        };

        private void test()
        {
            ParamsKeyword obj = new ParamsKeyword();
            //Passing  1D Array
            obj.paramsmethodTest(arr);

            //Cannot pass  2D or 3D arrays to params

            //Passing Array of Arrays 
            paramsmethodTest1(arrayofArrays);

        }

        private void paramsmethodTest(params int[] arr)
        {

        }
        private void paramsmethodTest1(params int[][] arr)
        {

        }
        //Params cannot be 2 d array it accepts 1D array
        //void paramsmethodTesttwoD(params int[,] arr)
        //{

        //}

    }

}
