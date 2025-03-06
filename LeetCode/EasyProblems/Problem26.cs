namespace LeetCode.EasyProblems;

public class Problem26
{
    public int RemoveDuplicates(int[] nums)
    {
        var k = 1;
        for (var i = 1; i < nums.Length; i++)
            if (nums[k - 1] != nums[i])
                nums[k++] = nums[i];

        return k;
    }
}