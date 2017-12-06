using advent;
using Xunit;

namespace Test
{
    public class Day3Tests
    {
        [Fact]
        public void Test1Problem1()
        {
            var test = Day3.Problem1(1);
            Assert.Equal(0, test);
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
    }
}