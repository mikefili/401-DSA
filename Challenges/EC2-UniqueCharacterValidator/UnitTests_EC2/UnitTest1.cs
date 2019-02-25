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
        public void CanValidateStringUnique()
        {
            Assert.True(Program.UniqueCharValidator("abcdefghijklmnopqrstuvwxyz"));
        }

        [Fact]
        public void CanValidateStringNotUnique()
        {
            Assert.False(Program.UniqueCharValidator("this will fail"));
        }

        [Fact]
        public void CanValidateStringUniqueWithSpaces()
        {
            Assert.True(Program.UniqueCharValidator("a b c d e f g h i j k l m n o p q r s t u v w x y z"));
        }

        [Fact]
        public void CanValidateStringUniqueCaseSensitive()
        {
            Assert.True(Program.UniqueCharValidator("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"));
        }

        [Fact]
        public void CanValidateStringUniqueWithSpacesCaseSensitive()
        {
            Assert.True(Program.UniqueCharValidator("A B C D E F G H I J K L M N O P Q R S T U V W X Y Z a b c d e f g h i j k l m n o p q r s t u v w x y z"));
        }
    }
}
