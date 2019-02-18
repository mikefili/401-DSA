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
            string actual = Hashtable.HT[key].Value;
            Assert.Equal("Filicetti", actual);
        }

        [Fact]
        public void CanHandleCollision()
        {
            Hashtable HT = new Hashtable(1024);
            HT.Add("mile", "high");
            string key1 = HT.Get("mile");
            HT.Add("lime", "coconut");
            string key2 = HT.Get("lime");
            Assert.NotEqual(key1, key2);
        }

        [Fact]
        public void CanGetValueGivenKey()
        {
            Hashtable HT = new Hashtable(1024);
            HT.Add("Mike", "Filicetti");
            string actual = HT.Get("Mike");
            Assert.Equal("Filicetti", actual);
        }

        [Fact]
        public void CanReturnNullIfKeyNotPresent()
        {
            Hashtable HT = new Hashtable(1024);
            Assert.Null(HT.Get("Mike"));
        }

        [Fact]
        public void CanCheckIfKeyExists()
        {
            Hashtable HT = new Hashtable(1024);
            HT.Add("Mike", "Filicetti");
            Assert.True(HT.Contains("Mike"));
        }

        [Fact]
        public void CanConfirmIfKeyNotPresent()
        {
            Hashtable HT = new Hashtable(1024);
            HT.Add("Mike", "Filicetti");
            Assert.False(HT.Contains("John"));
        }
    }
}
