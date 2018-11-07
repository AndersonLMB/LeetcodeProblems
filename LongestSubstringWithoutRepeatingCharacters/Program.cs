
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace LongestSubstringWithoutRepeatingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        //public static int LengthOfLongestSubstring(string s)
        //{

        //    int maxLength = 0;
        //    int inputStringLength = s.Length;
        //    Trace.WriteLine(s);

        //    //遍历每种长度
        //    for (int testStrLen = inputStringLength; testStrLen > 0; testStrLen--)
        //    {

        //        Trace.WriteLine(testStrLen);
        //        //遍历每种开头
        //        for (int head = 0; head <= inputStringLength - testStrLen; head++)
        //        {
        //            bool thisStrShouldBeBreak = false;
        //            var end = head + testStrLen - 1;
        //            Trace.WriteLine($"head {head} end {end}");
        //            //测试每个character
        //            for (int i = head; i <= end; i++)
        //            {
        //                var testchar = s[i];
        //                var count = 0;

        //                for (int beTestIndex = head; beTestIndex <= end; beTestIndex++)
        //                {
        //                    var bestTestedChar = s[beTestIndex];
        //                    //Trace.WriteLine($"{i}.{testchar}  vs {beTestIndex}.{bestTestedChar}");
        //                    if (testchar == bestTestedChar)
        //                    {
        //                        count += 1;
        //                    }
        //                    if (count == 2)
        //                    {
        //                        break;
        //                    }
        //                }
        //                Trace.WriteLine($"{testchar} {count}");
        //                if (count == 2)
        //                {
        //                    thisStrShouldBeBreak = true;
        //                    break;
        //                }
        //            }
        //            if (thisStrShouldBeBreak)
        //            {
        //                continue;
        //            }
        //            return end - head + 1;










        //        }







        //    }
        //    return 0;
        //}

        //public static int LengthOfLongestSubstring(string s)
        //{
        //    int inputStringLength = s.Length;
        //    for (int testStrLen = inputStringLength; testStrLen > 0; testStrLen--)
        //    {
        //        for (int headIndex = 0; headIndex <= inputStringLength - testStrLen; headIndex++)
        //        {
        //            bool thisStrShouldBeBreak = false;
        //            var endIndex = headIndex + testStrLen - 1;
        //            //Trace.WriteLine($"head {headIndex} end {endIndex}");
        //            HashSet<char> vs = new HashSet<char>();
        //            for (int i = headIndex; i <= endIndex; i++)
        //            {
        //                if (vs.Contains(s[i]))
        //                {
        //                    thisStrShouldBeBreak = true;
        //                    break;
        //                }
        //                else
        //                {
        //                    vs.Add(s[i]);
        //                }
        //            }
        //            if (thisStrShouldBeBreak)
        //            {
        //                continue;
        //            }
        //            else
        //            {
        //                return testStrLen;
        //            }
        //        }
        //    }
        //    return 0;
        //}

        //只有这个不会Time Limit Exceeded
        public static int LengthOfLongestSubstring(string s)
        {
            int n = s.Length;
            HashSet<char> set = new HashSet<char>();
            int ans = 0, i = 0, j = 0;
            while (i < n && j < n)
            {
                if (!set.Contains(s[j]))
                {
                    set.Add(s[j++]);
                    ans = Math.Max(ans, j - i);
                }
                else
                {
                    set.Remove(s[i++]);
                }
            }
            return ans;
        }

        //public static int LengthOfLongestSubstring(string s)
        //{
        //    int len = s.Length;
        //    int ans = 0;
        //    bool allUnique(string ss, int headIndex, int endIndex)
        //    {
        //        HashSet<char> vs = new HashSet<char>();
        //        for (int i = headIndex; i < endIndex; i++)
        //        {
        //            char ch = ss[i];
        //            if (vs.Contains(ch)) return false;
        //            vs.Add(ch);
        //        }
        //        return true;
        //    }

        //    for (int headIndex = 0; headIndex < len; headIndex++)
        //    {

        //        for (int endIndex = headIndex + 1; endIndex <= len; endIndex++)
        //        {
        //            var unique = allUnique(s, headIndex, endIndex);
        //            if (unique) ans = Math.Max(ans, endIndex - headIndex);
        //            Trace.WriteLine($"{headIndex}-{endIndex}");
        //            Trace.WriteLine(unique);
        //        }



        //    }



        //    return ans;
        //}

        //public static int LengthOfLongestSubstring(string s)
        //{
        //    if (s.Length == 0) return 0;
        //    int maxlength = 1;
        //    int length = s.Length;
        //    bool norepeat(string testString)
        //    {
        //        var testlen = testString.Length;
        //        //test each char
        //        for (int i = 0; i < testlen; i++)
        //        {
        //            var count = 0;
        //            var testchar = testString[i];
        //            for (int j = 0; j < testlen; j++)
        //            {
        //                if (testchar == testString[j])
        //                {
        //                    count = count + 1;
        //                }
        //            }
        //            if (count > 1) return false;
        //        }
        //        return true;
        //    }

        //    for (int head = 0; head < length; head++)
        //    {
        //        for (int end = length - 1; end > head; end--)
        //        {
        //            Trace.WriteLine($"{head} {end}");
        //            string testString = "";
        //            for (int index = head; index <= end; index++)
        //            {
        //                testString = $"{testString}{s[index]}";
        //            }
        //            Trace.WriteLine(testString);

        //            var isNorepeat = norepeat(testString);
        //            if (isNorepeat)
        //            {
        //                maxlength = testString.Length;
        //            }

        //            //var isNorepeat = norepeat(testString);
        //            //if (isNorepeat)
        //            //{
        //            //    if (testString.Length > maxlength)
        //            //    {
        //            //        maxlength = testString.Length;
        //            //    }
        //            //}
        //            //else
        //            //{
        //            //    break;
        //            //}
        //        }

        //    }
        //    return maxlength;
        //}

    }
}
