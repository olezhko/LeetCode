/// <summary>
/// 3. Longest Substring Without Repeating Characters
/// Given a string s, find the length of the longest substring without repeating characters.
/// Input: s = "abcabcbb"
/// Output: 3
/// Explanation: The answer is "abc", with the length of 3.
/// </summary>
internal static class Solution_0003
{
    public static int LengthOfLongestSubstring(string s)
    {
        int length = 0, offset = 0;
        List<char> chars = new List<char>();
        for (var index = 0; index < s.Length; )
        {
            var charItem = s[index];
            int indexChar = chars.IndexOf(charItem);
            if (indexChar != -1)
            {
                index = indexChar + offset + 1;
                offset = index;
                length = Math.Max(length, chars.Count);
                chars.Clear();
            }
            else
            {
                chars.Add(charItem);
                index++;
            }
        }

        return Math.Max(length, chars.Count);
    }
}