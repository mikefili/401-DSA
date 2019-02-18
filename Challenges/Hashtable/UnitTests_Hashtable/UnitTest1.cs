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
            Hashtable HT = new Hashtable(1024);
            int actual = Hashtable.Hash("Cat");
            Assert.Equal(136, actual);
        }

        [Fact]
        public void CanAddKeyValuePairToHashTable()
        {
            Hashtable HT = new Hashtable(1024);
            HT.Add("Mike", "Filicetti");
            int key = Hashtable.Hash("Mike");
            Assert.Equal("Filicetti", Hashtable.HT[key].Value);
        }
    }
}
