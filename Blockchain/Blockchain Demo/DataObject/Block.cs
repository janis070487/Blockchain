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
        public bool status = true;
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

        }
    }
}
