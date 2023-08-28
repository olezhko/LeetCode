using System.Collections.Generic;
/// <summary>
/// 168. Excel Sheet Column Title
/// Given an integer columnNumber, return its corresponding column title as it appears in an Excel sheet.
/// Z -> 26, AB -> 28 ,ZY -> 701
/// </summary>
internal class Solution_0168
{
    static int z = 26;
    public static string ConvertToTitle(int columnNumber)
    {
        char last = ' ';
        if (columnNumber <= z)
        {
            last = (char)(columnNumber - 1 + 'A');
            return last.ToString();
        }

        int temp = columnNumber;
        
        var num = temp / z;
        var left = temp % z;
        if (left == 0)
        {
            num--;
            last = 'Z';
        }
        else
        {
            last = (char)(left - 1 + 'A');
        }

        return $"{ConvertToTitle(num)}{last}";
    }
}