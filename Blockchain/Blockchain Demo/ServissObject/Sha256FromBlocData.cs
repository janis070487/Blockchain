
using System.Security.Cryptography;

namespace Blockchain_Demo
{
    public class Sha256FromBlocData
    {
        SHA256 sha256; // = new SHA256();
        public Sha256FromBlocData()
        {
            sha256 = new SHA256CryptoServiceProvider();
        }
        public byte[] GetSha256(BlockData block)
        {
            return sha256.ComputeHash(block.data);

        }
    }
}
