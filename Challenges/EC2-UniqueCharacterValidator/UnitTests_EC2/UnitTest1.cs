using System;
using Xunit;
using EC2_UniqueCharacterValidator;

namespace UnitTests_EC2
{
    public class UnitTest1
    {
        [Fact]
        public void CanValidateEmptyString()
        {
            Assert.True(Program.UniqueCharValidator(""));
        }

        [Fact]
        public void CanValidateUniqueString()
        {
            Assert.True(Program.UniqueCharValidator("abcdefghijklmnopqrstuvwxyz"));
        }
    }
}
