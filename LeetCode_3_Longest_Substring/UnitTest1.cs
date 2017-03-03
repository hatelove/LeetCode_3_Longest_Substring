using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

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

        [TestMethod]
        public void s_is_bb_should_return_1()
        {
            AssertLength("bb", 1);
        }

        [TestMethod]
        public void s_is_ba_should_return_2()
        {
            AssertLength("ba", 2);
        }

        [TestCategory("from LeetCode")]
        [TestMethod]
        public void s_is_abcabcbb_length_should_be_3()
        {
            AssertLength("abcabcbb", 3);
        }
    }

    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (s.Length == 1)
            {
                return 1;
            }

            var set = new HashSet<char>();
            foreach (var c in s)
            {
                set.Add(c);
            }

            return set.Count;
        }
    }
}