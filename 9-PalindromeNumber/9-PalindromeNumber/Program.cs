Console.WriteLine(new Solution().IsPalindrome(12321));
public class Solution
{
    public bool IsPalindrome(int x)
    {
        if(x < 0)
        {
            return false;
        }
        int y = x;
        int z = 0;
        while(y!=0)
        {
            z = z * 10;
            z += y % 10;
            y /= 10;
        }
        if(z == x)
        {
            return true;
        }
        return false;
    }
}