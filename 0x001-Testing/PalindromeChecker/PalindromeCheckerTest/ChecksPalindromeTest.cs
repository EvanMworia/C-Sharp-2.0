using PalindromeChecker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeCheckerTest
{
    [TestFixture]
    public class ChecksPalindromeTest
    {
        [Test]
        public void palindromeChecker_WhenCalled_ShouldCheckIfInputIsPalindrome()
        {

            //TRIPLE A
            //ARRANGE
            ChecksPalindromes test = new ChecksPalindromes();
            //ACT
            var result = test.isThisAPalindrome(" ");
            //ASSERT
            Assert.That(result, Is.EqualTo("  "));
        }
    }
}
