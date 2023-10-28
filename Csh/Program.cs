

namespace CshAlgo.algo
{

    internal class Program
    {
        private static int[] arr1 = { 2, 2, 1 };
        private static int[] arr2 = { 4, 1, 2, 1, 2 };

        static void Main(string[] args)
        {
            //gcd.gcd_cal(16,4);
            PascalTriangle ps = new PascalTriangle();
            //ps.Create(5);
            ps.Create2(5);
           
            //Bubble_sort.Run();
        }


        static void Print<T>(T f)
        {
            Console.WriteLine(f);
        }

    }
}