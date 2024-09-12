namespace Practice.Grind75.Easy
{
    public class BestTimeToBuyAndSellStock
    {
        public static int MaxProfit(int[] prices)
        {
            // SET min
            // initialize min to int.MaxValue instead of 0 to ensure it's updated correctly 
            // to the smallest price in the array, regardless of whether prices are positive or zero
            var min = int.MaxValue;
            // SET max
            var max = 0;
            // FOR each price in prices
            for (var i = 0; i < prices.Length; i++)
            {
                // SET price
                var price = prices[i];
                // IF price is smaller than min
                if (price < min)
                {
                    // UPDATE min to price
                    min = price;
                }
                // SET profit to price - min
                var profit = price - min;
                // IF price is greater than max
                if (profit > max)
                {
                    // UPDATE max to price
                    max = profit;
                }
            }

            return max;
        }
    }
}
