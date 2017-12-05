using advent;
using Xunit;

namespace Test
{
    public class Day2Tests
    {
        [Fact]
        public void TestProcessRow5195Problem1()
        {
            var test = Day2.ProcessRow("5 1 9 5");
            Assert.Equal(8, test);
        }

        [Fact]
        public void TestProcessRow753Problem1()
        {
            var test = Day2.ProcessRow("7 5 3");
            Assert.Equal(4, test);
        }

        [Fact]
        public void TestProcessRow2468Problem1()
        {
            var test = Day2.ProcessRow("2 4 6 8");
            Assert.Equal(6, test);
        }

        [Fact]
        public void TestProcessRowTabsProblem1()
        {
            var test = Day2.ProcessRow("5\t7\t2");
            Assert.Equal(5, test);
        }

        [Fact]
        public void TestProblem1Rows()
        {
            var input = "5 1 9 5\n7 5 3\n2 4 6 8";
            var test = Day2.Problem1(input);
            Assert.Equal(18, test);
        }
    }
}