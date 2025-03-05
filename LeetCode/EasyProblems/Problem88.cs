namespace LeetCode.EasyProblems;

public class Problem88
{
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        var mCurr = 0;
        var nCurr = 0;
        var result = new int[nums1.Length];

        while (mCurr < m || nCurr < n)
        {
            if (mCurr == m)
                result[mCurr + nCurr] = nums2[nCurr++];
            else if (nCurr == n)
                result[mCurr + nCurr] = nums1[mCurr++];
            else if (nums1[mCurr] <= nums2[nCurr])
                result[mCurr + nCurr] = nums1[mCurr++];
            else
                result[mCurr + nCurr] = nums2[nCurr++];
        }

        Array.Copy(result, nums1, nums1.Length);
    }
}