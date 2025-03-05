namespace LeetCode.EasyProblems
{
    public class Problem1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
                for (int j = i + 1; j < nums.Length; j++)
                    if (nums[i] + nums[j] == target) return [i, j];

            throw new Exception("Incorrect inputs");
        }

        public int[] TwoSumTheBest(int[] nums, int target)
        {
            Dictionary<int, int> d = new();
            int j, i = 0;
            for (; !d.TryGetValue(target - nums[i], out j); d[nums[i]] = i++);
            return [j, i];
        }
    }
}
