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
            Check(4);   // pārbauda vai ir vajadzīgais rezultāts
        }
        public void Check(int how) // pārbauda vai bloki ir pareizi
        {
            int counter = 0;
            for(int i = 0; i < blockchain.block.Length; i++) //Pārbauda katru bloku vai atbilst vajadzīgajam paveiktajam darbam
            {
                for(int a = 0; a < how; a++) // Pārbauda vai ir vajadzīgās nules katram blokam
                {
                    if (blockchain.block[i].blockTxt.hashSum[a] == '0') // ja kārtējais pārbaudāmais skaitlis atbilst vajadzigajam
                         // tad rezultatam pieskaita viens
                    {
                        counter++;
                    }
                    else
                    {
                        blockchain.block[i].status = false; // Ja neatbilst tad statusu ieliek folse
                        break;                              // un pārtrauc siklu
                    }
                }
                if(how == counter)   // ja netika partraukts cikls tad pārbauda vai ir vajadzīgo simbolu skaits ja jā
                {
                    blockchain.block[i].status = true; // tad parbaudāmā cikla statusu ieststa true
                }
                counter = 0; // skaititāju iestata nules vērtībā lai nakamo bloku parbauditu

            }
        }
        public void LoadFirstDataInBloc()
        {
           for(int i = 0; i < blockchain.block.Length; i++)
            {
                blockchain.block[i].blockTxt.nonce = FirstData.Data[i];
               // blockchain.block[i].blockTxt.prewHashSum = FirstData.Data[i + 1];
                //blockchain.block[i].blockTxt.hashSum = FirstData.Data[i + 2];
            }
        }
    
       
        


    }
}
