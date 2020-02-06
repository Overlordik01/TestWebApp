

using TestWebApp.Interfaces;
using TestWebApp.Services;
using Xunit;

namespace TestWebApp.Tests
{
    public class SummatorTest
    {

        [Fact]
        public void SummatorTestPositiveOnPositive() 
        {
            Summator summator = new Summator();

            Assert.Equal(8, summator.Sum(5,3));
        }

        [Fact]
        public void SummatorTestPositiveOnNegative()
        {
            Summator summator = new Summator();

            Assert.Equal(2, summator.Sum(5, -3));
        }

        [Fact]
        public void SummatorTestNegativeOnNegative()
        {
            Summator summator = new Summator();

            Assert.Equal(-8, summator.Sum(-5, -3));
        }
    }
}
