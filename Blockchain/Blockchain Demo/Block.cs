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
            blockTxt.number = "";
            blockTxt.nonce = "";
            blockTxt.data = "";
            blockTxt.prewHashSum = "";
            blockTxt.hashSum = "";
        }
        
        public void SetData() // Iestata jaunos datus pec teksta izmainas lai varētu pārrēiķināt hesh summu
        {
            string sumString = blockTxt.number + blockTxt.nonce + blockTxt.data + blockTxt.prewHashSum;
            byte[] sumData = new byte[sumString.Length];
            for (int i = 0; i < sumString.Length; i++)
            {
                sumData[i] = Convert.ToByte(sumString[i]);
            }
            blockdata.data = sumData;
        }
        public void SetAnswerBlockTxt()  // iestata teksta laukā kas atēlo bloka hesh summu no hesh funkcījas iegūto atbildi
        {
            blockTxt.hashSum = GetHexToByte.GetHex(blockdata.hashSum);
            /*
            for (int i = 0; i < blockdata.hashSum.Length; i++)
            {
                string value = Convert.ToString(blockdata.hashSum[i], toBase: 16);
                if (value != "0")
                {
                    blockTxt.hashSum += Convert.ToString(blockdata.hashSum[i], toBase: 16);
                }
                else
                {
                    blockTxt.hashSum += "0";
                }
            }
            */
            /*
          if (blockTxt.hashSum.Length != 64)
          {
              for(int i = blockTxt.hashSum.Length + 1; i <= 64; i++)
              {
                  blockTxt.hashSum = "0" + blockTxt.hashSum;
              }
          }
          */
        }
    }
}
