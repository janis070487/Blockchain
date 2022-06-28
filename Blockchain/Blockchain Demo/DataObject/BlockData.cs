
namespace Blockchain_Demo
{
    public class BlockData
    {
        public byte[] data { get; set; }
        public byte[] hashSum { get; set; }
        public BlockData()
        {
            hashSum = new byte[32];
        }
    }
}
