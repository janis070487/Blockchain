using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockchain_Demo
{
    public class BlockData
    {
        public byte[] data { get; set; }
        public byte[] hashSum { get; set; }
        public BlockData()
        {
            hashSum = new byte[64];
        }
    }
}
