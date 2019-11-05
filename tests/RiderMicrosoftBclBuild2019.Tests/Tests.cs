using System.Net.Http;
using Xunit;

namespace RiderMicrosoftBclBuild2019.Tests
{
    public class Tests
    {
        [Fact]
        public void Test1()
        {
            var client = new HttpClient();
            var result = Program.GetBaseAddress(client);
            Assert.Equal(null, result);
        }
    }
}