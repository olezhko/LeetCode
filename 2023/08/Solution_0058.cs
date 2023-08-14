/// <summary>
/// Given a string s consisting of words and spaces, return the length of the last word in the string.
/// A word is a maximal substring consisting of non-space characters only.
/// </summary>
public class Solution_0058
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