using advent;
using Xunit;

namespace Test
{
    public class Day4Tests
    {
        [Fact]
        public void TestIsValidPassphraseValid()
        {
            var test = Day4.IsValidPassphrase("aa bb cc dd ee");
            Assert.Equal(true, test);
        }

        [Fact]
        public void TestIsValidPassphraseInvalid()
        {
            var test = Day4.IsValidPassphrase("aa bb cc dd aa");
            Assert.Equal(false, test);
        }

        [Fact]
        public void TestIsValidPassphraseWordContainsAnotherWord()
        {
            var test = Day4.IsValidPassphrase("aa bb cc dd aaa");
            Assert.Equal(true, test);
        }

        [Fact]
        public void TestProblem1()
        {
            var test = Day4.Problem1("aa bb cc dd ee\naa bb cc dd aa\naa bb cc dd aaa");
            Assert.Equal(2, test);
        }
    }
}
