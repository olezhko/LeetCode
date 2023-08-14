/// <summary>
/// 9. Palindrome Number
/// Given an integer x, return true if x is a palindrome , and false otherwise.
/// </summary>
internal class Solution_0009
{
    public static bool IsPalindrome(int x)
    {
        if (x < 0)
        {
            return false;
        }

        string valueX = x.ToString();
        int length = valueX.Length;
        int lastIndex = length / 2;
        for (int i = 0; i < lastIndex; i++)
        {
            if (valueX[i] != valueX[length - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}