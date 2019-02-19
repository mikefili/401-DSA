using System;
using Xunit;
using RepeatedWord;

namespace UnitTests_RepeatedWord
{
    public class UnitTest1
    {
        [Fact]
        public void CanFindRepeatedWord()
        {
            string actual = Program.RepeatedWord("this one time there was this test I had to get to pass");
            string expected = "this";
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanFindRepeatedWordCaseSensitive()
        {
            string actual = Program.RepeatedWord("It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only...");
            string expected = "it";
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanDetectNoRepeats()
        {
            string actual = Program.RepeatedWord("There are no repeats in this string.");
            string expected = "No Repeated Words";
            Assert.Equal(expected, actual);
        }
    }
}
