using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshAlgo.practice.type_p
{
    public struct MutablePoint {
        public int X;
        public int Y;
        public MutablePoint(int x, int y) => (X, Y) = (x, y);
        public override string ToString()
        {
            return $"({X}, {Y})";
        }

        public static void Test() { 
            MutablePoint mp = new MutablePoint(1,2);
            string res = mp.ToString();
            Console.WriteLine(res);
        }
    }

    public struct Coords
    {
        public double X { get; }
        public double Y { get; }
        public Coords(double x, double y) {
            this.X = x;
            this.Y = y;
        }
        public override string ToString() { return $"({X}, {Y})"; }
    }
}
