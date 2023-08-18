//Console.WriteLine(Solution_0001.TwoSum(new []{ 2, 7, 11, 15 }, 9).SequenceEqual(new[] { 0, 1 }));
//Console.WriteLine(Solution_0009.IsPalindrome(121));
//Console.WriteLine(!Solution_0009.IsPalindrome(-121));
//Console.WriteLine(Solution_0009.IsPalindrome(1221));
//Console.WriteLine(Solution_58.LengthOfLastWord("luffy is still joyboy") == 6);


//Console.WriteLine(Solution_0215.FindKthLargest(new []{ 3, 2, 1, 5, 6, 4 }, 2) == 5);
//Console.WriteLine(Solution_0215.FindKthLargest(new []{ 3, 2, 3, 1, 2, 4, 5, 5, 6 }, 4) == 4);

using System.Diagnostics;

Stopwatch watch = Stopwatch.StartNew();
Console.WriteLine(Solution_0215.FindKthLargest(new []{ 3, 2, 3, 1, 2, 4, 5, 5, 6, 7, 7, 8, 2, 3, 1, 1, 1, 10, 11, 5, 6, 2, 4, 7, 8, 5, 6 }, 20) == 2);
watch.Stop();
Console.WriteLine(watch.ElapsedMilliseconds);

Console.ReadKey();