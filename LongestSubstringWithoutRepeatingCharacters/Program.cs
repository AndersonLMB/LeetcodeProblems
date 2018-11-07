
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
        public static int LengthOfLongestSubstring(string s)
        {
            if (s.Length == 0) return 0;
            int maxlength = 1;
            int length = s.Length;
            bool norepeat(string testString)
            {
                var testlen = testString.Length;
                //test each char
                for (int i = 0; i < testlen; i++)
                {
                    var count = 0;
                    var testchar = testString[i];
                    for (int j = 0; j < testlen; j++)
                    {
                        if (testchar == testString[j])
                        {
                            count = count + 1;
                        }
                    }
                    if (count > 1) return false;
                }
                return true;
            }

            for (int head = 0; head < length; head++)
            {
                for (int end = head; end < length; end++)
                {
                    string testString = "";

                    for (int index = head; index <= end; index++)
                    {
                        testString = $"{testString}{s[index]}";
                        //Trace.WriteLine($"{head} - {end} {testString}");
                    }
                    var isNorepeat = norepeat(testString);
                    if (isNorepeat)
                    {
                        if (testString.Length > maxlength)
                        {
                            maxlength = testString.Length;
                        }
                    }
                    else
                    {
                        break;
                    }
                }

            }
            return maxlength;
        }
    }
}
