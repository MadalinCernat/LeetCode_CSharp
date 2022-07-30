int[] nums = { 1, 3, 5, 6 };
Console.WriteLine(new Solution().SearchInsert(nums, 0));

public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        int l = 0, r = nums.Length - 1, m, poz = 0;
        while (l <= r)
        {
            m = (l + r) / 2;
            if (target < nums[m])
            {
                r = m - 1;
                poz = r + 1;
            }
            else if (target > nums[m])
            {
                l = m + 1;
                poz = l;
            }
            else
            {
                return m;
            }
        }
        return poz;
    }
}
