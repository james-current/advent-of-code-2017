using advent;
using Xunit;

namespace Test
{
    public class Day3Tests
    {
        private const int Real = 289326;

        [Fact]
        public void Test1CalculateLocation()
        {
            var test = Day3.CalculateLocation(1);
            Assert.Equal((0, 0), test);
        }

        [Fact]
        public void Test1Problem1()
        {
            var test = Day3.Problem1(1);
            Assert.Equal(0, test);
        }

        [Fact]
        public void Test12CalculateLocation()
        {
            var test = Day3.CalculateLocation(12);
            Assert.Equal((2, 1), test);
        }

        [Fact]
        public void Test12Problem1()
        {
            var test = Day3.Problem1(12);
            Assert.Equal(3, test);
        }

        [Fact]
        public void Test23Problem1()
        {
            var test = Day3.Problem1(23);
            Assert.Equal(2, test);
        }

        [Fact]
        public void Test1024Problem1()
        {
            var test = Day3.Problem1(1024);
            Assert.Equal(31, test);
        }

        [Fact]
        public void TestRealProblem1()
        {
            var test = Day3.Problem1(Real);
            Assert.Equal(419, test);
        }

        [Fact]
        public void Test8Problem2()
        {
            var test = Day3.Problem2(8);
            Assert.Equal(10, test);
        }

        [Fact]
        public void Test24Problem2()
        {
            var test = Day3.Problem2(24);
            Assert.Equal(25, test);
        }

        [Fact]
        public void Test25Problem2()
        {
            var test = Day3.Problem2(25);
            Assert.Equal(26, test);
        }

        [Fact]
        public void Test53Problem2()
        {
            var test = Day3.Problem2(53);
            Assert.Equal(54, test);
        }

        [Fact]
        public void Test145Problem2()
        {
            var test = Day3.Problem2(145);
            Assert.Equal(147, test);
        }

        [Fact]
        public void Test879Problem2()
        {
            var test = Day3.Problem2(879);
            Assert.Equal(880, test);
        }

        [Fact]
        public void Test930Problem2()
        {
            var test = Day3.Problem2(930);
            Assert.Equal(931, test);
        }

        [Fact]
        public void TestRealProblem2()
        {
            var test = Day3.Problem2(289326);
            Assert.Equal(295229, test);
        }
    }
}
