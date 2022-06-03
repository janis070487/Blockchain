using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockchain_Demo
{
    public class Core
    {
        public Blockchain blockchain;
        public Sha256FromBlocData sha256FromBlock; 
        public Core(int howBlock)
        {
            blockchain = new Blockchain(howBlock);
            sha256FromBlock = new Sha256FromBlocData();
        }

        public void ResetData() // pec katras teksta izmainas visu izmaina
        {
            for(int i  = 0; i < blockchain.block.Length; i++)
            {
                 blockchain.block[i].blockdata = sha256FromBlock.GetSha256( blockchain.block[i].blockdata);
                //sha256FromBlock.GetSha256(blockchain.block[i].blockdata);

                blockchain.block[i].SetAnswerBlockTxt();
                if(i < blockchain.block.Length - 1)
                {
                    blockchain.block[i + 1].blockTxt.prewHashSum = blockchain.block[i].blockTxt.hashSum;
                }
            }
        }
       
    }
}
