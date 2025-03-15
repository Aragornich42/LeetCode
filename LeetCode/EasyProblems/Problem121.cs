namespace LeetCode.EasyProblems;

public class Problem121
{
    public int MaxProfit(int[] prices)
    {
        var maximum = 0;
        var minPrice = prices[0];

        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] < minPrice)
                minPrice = prices[i];
            var diff = prices[i] - minPrice;
            if (diff > maximum)
                maximum = diff;
        }
        
        return maximum;
    }
}