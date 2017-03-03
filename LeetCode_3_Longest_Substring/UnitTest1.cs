using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_3_Longest_Substring
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void s_is_a_should_return_a()
        {
            var s = "a";
            Assert.AreEqual("a", new Solution().LengthOfLongestSubstring(s));
        }
    }

    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            throw new NotImplementedException();
        }
    }
}
