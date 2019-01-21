using System;
using Xunit;
using ALGO;

namespace ALGOTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var lruWithArray = new LruWithArray(30);
            lruWithArray.Set(60);
            
            Assert.Equal(60, lruWithArray.CachedList.Find(0));
        }
    }
}