public class Solution
{
    public int PunishmentNumber(int n)
    {
        int res = 0;
        for (int i = 1; i <= n; i++)
        {
            if (Partition(0, 0, i, (i * i).ToString()))
            {
                res += i * i;
            }
        }
        return res;
    }

    private bool Partition(int i, int curr, int target, string s)
    {
        if (i == s.Length && curr == target)
        {
            return true;
        }

        for (int j = i; j < s.Length; j++)
        {
            string substring = s.Substring(i, j - i + 1);
            int num = int.Parse(substring);
            if (Partition(j + 1, curr + num, target, s))
            {
                return true;
            }
        }
        return false;
    }
}