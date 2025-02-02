public class Solution
{
    public void ReverseString(char[] s)
    {
        int len = s.Length;
        for (int i = 0; i < len / 2; i++)
        {
            (s[i], s[len - 1 - i]) = (s[len - 1 - i], s[i]);
        }
    }
}