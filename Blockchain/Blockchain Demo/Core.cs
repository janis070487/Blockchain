using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Blockchain_Demo
{
    public class Core
    {

        public Blockchain blockchain;
        public Sha256FromBlocData sha256FromBlock;
        public Maining maining;
        public int howManyZeros { get; set; }
        public int maximumNumberOfAttempts { get; set; }
        
        public Core(int howBlock)
        {
            blockchain = new Blockchain(howBlock);
            sha256FromBlock = new Sha256FromBlocData();
            maining = new Maining();
        }

        public void MainingStartOneBlock(int blockNumber)
        {
             //Mianingo norādito bloku
           string nonce = maining.MainingRun(blockchain.block[blockNumber - 1].blockTxt, howManyZeros, maximumNumberOfAttempts);
            blockchain.block[blockNumber -1].blockTxt.nonce = nonce;
            ResetData();
        }
        public void MainingStartAllBlocks()                 //mainingo visus blokus
        {
            for (int i = 0; i < blockchain.block.Length; i++)
            {
                if (!blockchain.block[i].status)  // Ja bloks jau satur vajadzīgo hes summu tad to nesūta uz mainingu
                {
                    string nonce = maining.MainingRun(blockchain.block[i].blockTxt, howManyZeros, maximumNumberOfAttempts);
                    blockchain.block[i].blockTxt.nonce = nonce;
                    ResetData();
                }
                ResetData();
            }
          
        }

        public void ResetData() // pec katras teksta izmainas visu izmaina
        {
            for (int i = 0; i < blockchain.block.Length; i++)
            {
                blockchain.block[i].SetData();
                blockchain.block[i].blockdata.hashSum = sha256FromBlock.GetSha256(blockchain.block[i].blockdata);
                blockchain.block[i].SetAnswerBlockTxt();
                if (i < blockchain.block.Length - 1)
                {
                    blockchain.block[i + 1].blockTxt.prewHashSum = blockchain.block[i].blockTxt.hashSum;
                    blockchain.block[i].SetData();
                }
            }
            Check(howManyZeros);   // pārbauda vai ir vajadzīgais rezultāts
        }
        public void Check(int how)
        {
            for (int i = 0; i < blockchain.block.Length; i++) //Pārbauda katru bloku vai atbilst vajadzīgajam paveiktajam darbam
            {
                blockchain.block[i].status = CheckBlock.Check(how, blockchain.block[i].blockTxt.hashSum);
            }
         }
        public void LoadFirstDataInBloc()
        {
           for(int i = 0; i < blockchain.block.Length; i++)
            {
                blockchain.block[i].blockTxt.nonce = FirstData.Data[i];
            }
        }
    
       
        public int CheckValue(string sms)
        {
            int answer;
            bool a = int.TryParse(sms, out answer);
            if (sms.Length == 0)
            {
                return 0;
            } else if(!a)
            {
                MessageBox.Show("Tika ievadīts nepareizs simbols", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return answer;
        }


    }
}
