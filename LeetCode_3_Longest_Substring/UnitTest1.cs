using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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

        [TestCategory("from LeeetCode")]
        [TestMethod]
        public void s_is_pwwkew_length_should_be_3()
        {
            AssertLength("pwwkew", 3);
        }

        [TestCategory("from LeeetCode")]
        [TestMethod]
        public void s_is_dvdf_length_should_be_3()
        {
            AssertLength("dvdf", 3);
        }

        [Ignore]
        [TestMethod]
        public void s_is_babacd_length_should_be_4()
        {
        }

        [Ignore]
        [TestMethod]
        public void s_is_joeeyjo_length_should_be_4()
        {
            AssertLength("joeeyjd", 4);
        }
    }

    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            var charArray = s.ToCharArray();

            var dictionary = new Dictionary<char, int>();
            var index = 0;
            var resultLength = 0;

            while (index < charArray.Length)
            {
                var c = charArray[index];

                if (dictionary.ContainsKey(c))
                {
                    resultLength = Math.Max(resultLength, dictionary.Count);
                    index = dictionary[c];
                    dictionary.Clear();
                }
                else
                {
                    dictionary.Add(c, index);
                }

                index++;
            }

            return Math.Max(resultLength, dictionary.Count);
        }
    }
}