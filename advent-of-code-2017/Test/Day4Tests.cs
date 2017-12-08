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
    }
}
