
using ConsoleApp2.algo;

namespace ConsoleApp2
{

    internal class Program
    {
        private static int[] arr1 = { 2, 2, 1 };
        private static int[] arr2 = { 4, 1, 2, 1, 2 };

        static void Main(string[] args)
        {   
            Bubble_sort.Run();
        }


        static void Print<T>(T f)
        {
            Console.WriteLine(f);
        }
    }
}