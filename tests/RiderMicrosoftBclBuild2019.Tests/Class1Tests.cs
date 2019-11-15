using System;
using Xunit;

namespace RiderMicrosoftBclBuild2019.Tests
{
    public class Class1Tests
    {
        [Fact]
        public void TestMethod1()
        {
            var sut = new Class1();
            var result = sut.Method1();
            Assert.NotNull(result);
        }
    }
}
