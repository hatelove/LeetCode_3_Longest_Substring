using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_3_Longest_Substring
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void s_is_a_should_return_1()
        {
            AssertLength("a", 1);
        }

        private static void AssertLength(string s, int expected)
        {
            Assert.AreEqual(expected, new Solution().LengthOfLongestSubstring(s));
        }
    }

    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            return s.Length;
        }
    }
}
