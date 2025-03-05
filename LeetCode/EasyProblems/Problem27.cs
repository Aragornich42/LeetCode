namespace LeetCode.EasyProblems;

public class Problem27
{
    public int RemoveElement(int[] nums, int val) {
        int i = 0;
        int k = nums.Length;

        while (i < k)
        {
            if (nums[i] == val)
            {

                (nums[i], nums[k - 1]) = (nums[k - 1], nums[i]);
                k--;
            }
            else
            {
                i++;
            }
        }

        return k == 1 && nums[0] == val ? 0 : k;
    }
}