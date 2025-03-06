using System.Data.Common;

namespace LeetCode.EasyProblems;

public class Problem169
{
    public int MajorityElement(int[] nums)
    {
        var dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length / 2 + 1; i++)
        {
            if (i != nums.Length - i - 1)
            {
                IncreaseOrAdd(dict, nums[i]);
                IncreaseOrAdd(dict, nums[nums.Length - i - 1]);
            }
            else
                IncreaseOrAdd(dict, nums[i]);
        }

        foreach (var kv in dict)
        {
            if (kv.Value > nums.Length / 2)
                return kv.Key;
        }

        throw new Exception("Has no majority element");
    }

    private void IncreaseOrAdd(Dictionary<int, int> dict, int value)
    {
        if (!dict.TryAdd(value, 1))
            dict[value]++;
    }
    
    
    
    public int MajorityElementTheBest(int[] nums)
    {
        int Majority = 0;
        int Count = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            if(Count == 0)
                Majority = nums[i];

            if(nums[i] == Majority)
                Count++;
            else
                Count--;
        }
        return Majority;
    }
}