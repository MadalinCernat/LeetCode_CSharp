public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        if(ransomNote == null)
        {
            return true;
        }
        if(magazine == null)
        {
            return false;
        }
        if(ransomNote.Length > magazine.Length)
        {
            return false;
        }
        int[] arr = new int[123];
        for (int i = 0; i < magazine.Length; i++)
        {
            arr[magazine[i]]++;
        }
        foreach (char ch in ransomNote)
        {
            arr[ch]--;
            if (arr[ch] < 0)
            {
                return false;
            }
        }
        return true;
    }
}