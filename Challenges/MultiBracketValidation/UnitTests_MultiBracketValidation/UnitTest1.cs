using System;
using Xunit;
using MultiBracketValidation;
using MultiBracketValidation.Classes;

namespace UnitTests_MultiBracketValidation
{
    public class UnitTest1
    {
        [Fact]
        public void CanValidateMatchingBrackets()
        {
            string testInput = "({[]})";
            Assert.True(Program.MultiBracketValidation(testInput));
        }
    }
}
