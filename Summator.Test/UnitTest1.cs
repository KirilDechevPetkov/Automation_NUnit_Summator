using NUnit.Framework;

namespace Summator.Test
{
    public class Tests
    {
        [Test]
        public void Test_sum_TwoPossitiveNumbers()
        {
            int result = Summator.Sum(new int[] { 5, 7 });

            Assert.That(result == 12);
        }
        [Test]
        public void Test_sum_OnePossitiveNumbers()
        {
            int result = Summator.Sum(new int[] { 5, });

            Assert.That(result == 5);
        }
        [Test]
        public void Test_sum_TwoNegativeumbers()
        {
            int result = Summator.Sum(new int[] { -5, -7 });

            Assert.That(result == -12);
        }
    }
}