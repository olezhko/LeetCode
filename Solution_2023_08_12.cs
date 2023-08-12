public class Solution_2023_08_12
{
    public static int LengthOfLastWord(string s)
    {
        int result = 0;
        int currentResult = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != ' ')
            {
                currentResult++;
            }
            else
            {
                if (currentResult != 0)
                {
                    result = currentResult;
                }
                currentResult = 0;
            }
        }

        if (currentResult != 0)
        {
            result = currentResult;
        }

        return result;
    }
}