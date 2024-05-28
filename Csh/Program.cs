using ConsoleApp2.grind_169;
using ConsoleApp2.practice.static_p;
using CshAlgo.grind_169.rewrite;
using CshAlgo.practice.record_p;
using CshAlgo.practice.type_p;

namespace CshAlgo.algo
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //ReWrite();
            //Person ps = new Person();
            //ps.Test();
            //MutablePoint.Test();
            Statics.Start();
        }

        static void ReWrite() {
            // CshAlgo.grind_169.rewrite.TwoSum tw = new CshAlgo.grind_169.rewrite.TwoSum();
            //tw.Start();
            BestTimeBuySell_121 BTBS = new BestTimeBuySell_121();
            BTBS.Start();

        }


        static void Print<T>(T f)
        {
            Console.WriteLine(f);
        }

        static void PascalTriangleTest()
        {
            PascalTriangle ps = new PascalTriangle();
            ps.Create2(5);

        }

    }
}