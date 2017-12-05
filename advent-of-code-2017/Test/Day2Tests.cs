using advent;
using Xunit;

namespace Test
{
    public class Day2Tests
    {
        [Fact]
        public void TestProcessRow5195Problem1()
        {
            var test = Day2.ProcessRow1("5 1 9 5");
            Assert.Equal(8, test);
        }

        [Fact]
        public void TestProcessRow753Problem1()
        {
            var test = Day2.ProcessRow1("7 5 3");
            Assert.Equal(4, test);
        }

        [Fact]
        public void TestProcessRow2468Problem1()
        {
            var test = Day2.ProcessRow1("2 4 6 8");
            Assert.Equal(6, test);
        }

        [Fact]
        public void TestProcessRowTabsProblem1()
        {
            var test = Day2.ProcessRow1("5\t7\t2");
            Assert.Equal(5, test);
        }

        [Fact]
        public void TestProblem1Rows()
        {
            var input = "5 1 9 5\n7 5 3\n2 4 6 8";
            var test = Day2.Problem1(input);
            Assert.Equal(18, test);
        }

        [Fact]
        public void TestProcessRow5928Problem2()
        {
            var test = Day2.ProcessRow2("5 9 2 8");
            Assert.Equal(4, test);
        }

        [Fact]
        public void TestProcessRow9473Problem2()
        {
            var test = Day2.ProcessRow2("9 4 7 3");
            Assert.Equal(3, test);
        }

        [Fact]
        public void TestProcessRow3865Problem2()
        {
            var test = Day2.ProcessRow2("3 8 6 5");
            Assert.Equal(2, test);
        }

        [Fact]
        public void TestProblem2Rows()
        {
            var input = "5 9 2 8\n9 4 7 3\n3 8 6 5";
            var test = Day2.Problem2(input);
            Assert.Equal(9, test);
        }
    }
}