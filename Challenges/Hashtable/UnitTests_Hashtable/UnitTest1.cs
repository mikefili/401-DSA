using System;
using Xunit;
using Hashtable.Classes;

namespace UnitTests_Hashtable
{
    public class UnitTest1
    {
        [Fact]
        public void CanHashArbitraryKey()
        {
            Assert.Equal(456, Hashtable.Classes.Hashtable.Hash("Cat"));
        }
    }
}
