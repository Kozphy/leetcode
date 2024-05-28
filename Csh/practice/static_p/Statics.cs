using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.practice.static_p
{
    internal class Statics
    {
        public static int bookCount = 0;

        public static void Start() { 
            StaticModifier();
        }

        private static void StaticModifier()
        {
            Statics s = new Statics();
            Console.WriteLine(bookCount);
            Console.WriteLine(s.getBookCount());

            /*
            Console.WriteLine(Math.Sqrt(144));
            UsefulTools.SayHi("123");
            Console.ReadLine();
            */
        }

        public int getBookCount()
        {
            return bookCount;
        }
    }
}
