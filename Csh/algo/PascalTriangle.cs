using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshAlgo.algo
{
    internal class PascalTriangle
    {
        public void Create(int numRows)
        {
            for (int i = 0; i < numRows; i++)
            {
                int number = 1;
                // how many white space do you want to print?
                Console.Write(new string(' ', (numRows - i) * 2));

                for (int j = 0; j <= i; j++)
                {
                    Console.Write($"{number,4}");
                    number = number * (i - j) / (j + 1);
                }
                Console.WriteLine();
            }
        }

        public void Create2(int numRows)
        {
            int[][] result = new int[numRows][];

            // 0 ~ 4
            for (int row = 0; row < numRows; row++)
            {
                // row(0 ~ 5) = 1...6 (space)
                result[row] = new int[row + 1];
                for (int col = 0; col <= row; col++)
                {
                    if (col == 0 || col == row)
                    {
                        result[row][col] = 1;
                    }
                    else
                    {
                        result[row][col] = result[row - 1][col - 1] + result[row - 1][col];
                    }
                }
            }

            var rows = result.GetLength(0);


            for (int i = 0; i < rows; i++)
            {
                var rowElements = result[i];
                Console.WriteLine(string.Join(" ", rowElements));
            }

        }
        /*
            how to create PascalTriangle in C#? output in following format: 
                    1
                1       1
            1       2       1
        */

    }
}