using System;
using Xunit;
using HashTable.Classes;

namespace UnitTests_Hashtable
{
    public class UnitTest1
    {
        [Fact]
        public void CanHashArbitraryKey()
        {
            Assert.Equal(456, HashTable.Classes.Hashtable.Hash("Cat"));
        }
    }
}
