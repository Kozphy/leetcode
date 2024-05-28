using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshAlgo.grind_169.rewrite
{
    internal class BestTimeBuySell_121
    {
        private int[] prices = new int[] { 7, 1, 5, 3, 6, 4 };
        private int[] prices2 = new int[] { 7, 6, 4, 3, 1 };

        public void Start() {
            int bestProfit = CalPriceBrute(prices);
            Console.WriteLine($"bestProfit {bestProfit}");
        }

        private int CalPriceBrute(int[] prices) {
            int p1 = 0;
            int p2 = 1;
            int maxProfit = 0;
            int lowerPrice = prices[p1];
            while (p2 < prices.Length) {
                if (lowerPrice > prices[p2]) {
                    lowerPrice = prices[p2];
                    p1 = p2;
                }

                int profit = prices[p2] - lowerPrice;

                if (profit > 0 && profit > maxProfit) {
                    maxProfit = profit;
                }
                p2++;
            }
            return maxProfit;
        }

        private int CalPrice2(int[] prices) {
            return 0;
        }
    }
}
