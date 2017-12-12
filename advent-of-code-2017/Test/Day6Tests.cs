using advent;
using Xunit;

namespace Test
{
    public class Day6Tests
    {
        private const string Real = @"0	5	10	0	11	14	13	4	11	8	8	7	1	4	12	11";
        private const string TestInput = @"0	2	7	0";
        
        [Fact]
        public void TestProblem1()
        {
            var test = Day6.Problem1(TestInput);
            Assert.Equal(5, test);
        }

        [Fact]
        public void TestProblem1Real()
        {
            var test = Day6.Problem1(Real);
            Assert.Equal(7864, test);
        }

        [Fact]
        public void TestProblem2()
        {
            var test = Day6.Problem2(TestInput);
            Assert.Equal(4, test);
        }
    }
}
