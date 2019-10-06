using System;
using Xunit;
using evip_hazi_A;

namespace tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Shop shop = new Shop();
            shop.RegisterProduct("A", 10);
            shop.RegisterProduct("C", 20);
            shop.RegisterProduct("E", 50);

            Assert.Equal("10", shop.GetVal("A"));
            Assert.Equal(130, shop.GetPrice("ACEE"));
        }
    }
}
