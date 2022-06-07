using Xunit;

namespace Blockchain_Demo.Test
{
    public class UnitTest1
    {
        [Fact]
        public void GetHexToByte_Test1()
       // public void Test1()
        {
            byte[] data = { 10, 20, 0, 255 };
            string answer = GetHexToByte.GetHex(data);
            Assert.Equal("0a1400ff", answer);
        }

        public void GetHexToByte_Test2()
        // public void Test1()
        {
            byte[] data = { 141, 142, 143, 144, 145, 147, 148 };
            string answer = GetHexToByte.GetHex(data);
            Assert.Equal("6162636465666768", answer);
        }

        public void GetHexToByte_Test3()
        // public void Test1()
        {
            byte[] data = { 0, 0, 255, 250, 240, 220, 170, 30, 0, 0 };
            string answer = GetHexToByte.GetHex(data);
            Assert.Equal("0000fffaf0dcaa1e0000", answer);
        }

        
    }
}