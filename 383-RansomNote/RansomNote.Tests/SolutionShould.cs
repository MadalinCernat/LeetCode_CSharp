using Xunit;

namespace RansomNote.Tests
{
    public class SolutionShould
    {
        [Theory]
        [InlineData("a", "b", false)]
        [InlineData("aa", "ab", false)]
        [InlineData("aa", "aab", true)]
        public void Check(string ransomNote, string magazine, bool expected)
        {
            Solution solution = new();

            var result = solution.CanConstruct(ransomNote, magazine);

            Assert.Equal(expected, result);
        }
    }
}
