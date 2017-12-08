using advent;
using Xunit;

namespace Test
{
    public class Day5Tests
    {
        [Fact]
        public void TestProblem1()
        {
            var test = Day5.Problem1("0\n3\n0\n1\n-3");
            Assert.Equal(5, test);
        }
    }
}