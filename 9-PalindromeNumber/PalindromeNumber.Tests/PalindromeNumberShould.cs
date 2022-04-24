using Xunit;

namespace PalindromeNumber.Tests
{
    public class PalindromeNumberShould
    {
        private readonly Solution _solution;
        public PalindromeNumberShould()
        {
            _solution = new Solution();
        }
        [Theory]
        [InlineData(121)]
        [InlineData(35253)]
        [InlineData(5)]
        public void ReturnTrueForPalindromeNumbers(int x)
        {
            bool result = _solution.IsPalindrome(x);

            Assert.True(result);
        }

        [Theory]
        [InlineData(133)]
        [InlineData(50)]
        [InlineData(1313)]
        public void ReturnFalseForNonPalindromeNumbers(int x)
        {
            bool result = _solution.IsPalindrome(x);

            Assert.False(result);
        }
    }
}