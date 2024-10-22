using System.Diagnostics;

namespace LeetCode.TopInterview150
{
    public static class _121BestTimeToBuyAndSellStock
    {
        public static int Exercise()
        {
            //Inputs
            int[] prices = [3, 2, 1];

            //Solution

            if (prices.Length == 1)
            {
                return 0;
            }

            int min = prices.Min();
            int minIndex = Array.IndexOf(prices, min);

            if (minIndex == prices.Length - 1)
            {
                prices = prices.Except(new int[] { min }).ToArray();

                min = prices.Min();
                minIndex = Array.IndexOf(prices, min);
            }

            int max = prices[minIndex..^0].Max();
            int maxIndex = Array.IndexOf(prices, max);

            Console.WriteLine(max - min);

            return max - min;
        }
    }
}
