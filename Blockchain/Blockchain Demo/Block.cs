using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockchain_Demo
{
    public class Block
    {
        public BlockData blockdata;
        public BlockTxt blockTxt;
        public Block()
        {
            blockdata = new BlockData();
            blockTxt = new BlockTxt();
        }
        public void SetData()
        {
            string sumString = blockTxt.number + blockTxt.nonce + blockTxt.data + blockTxt.prewHashSum;
            byte[] sumData = new byte[sumString.Length];
            for (int i = 0; i < sumString.Length; i++)
            {
                sumData[i] = (byte)sumString[i];
            }
            blockdata.data = sumData;
        }
        public void SetAnswerBlockTxt()
        {
            
            for (int i = 0; i < blockdata.hashSum.Length; i++)
            {
                blockTxt.hashSum += Convert.ToString(blockdata.hashSum[i], toBase: 16);
            }

        }
    }
}
