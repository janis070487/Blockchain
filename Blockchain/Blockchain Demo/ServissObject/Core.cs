using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
namespace Blockchain_Demo

{
    public class Core
    {
        public bool flage = false;// ------------------------------
        public Blockchain blockchain;
        public Sha256FromBlocData sha256FromBlock;
        public Maining maining;
        public Stopwatch stopWatch;
        public Info[] info { get; set; }
        public int howManyZeros { get; set; }
        public int maximumNumberOfAttempts { get; set; }
        public delegate void ResetInfo();
        public delegate void GetNext();

        //Del del = new(maining.MainingRun);
        public ResetInfo resetInfo { get; set; }
        // public event ResetInfo resetInfo;
        //public event GetNext getNext;
        public Core(int howBlock)
        {
            blockchain = new Blockchain(howBlock);
            sha256FromBlock = new Sha256FromBlocData();
            maining = new Maining();
            stopWatch = new Stopwatch();
            info = new Info[howBlock];
            for (int i = 0; i < info.Length; i++)
            {
                info[i] = new Info();
            }
        }

        public void MainingStartOneBlock(int blockNumber)
        {
            // public delegate string Del(string sms, int howManyZeros, int maximumNumberOfAttempts);




            //Mianingo norādito bloku
            ///*
            stopWatch.Start();
            string nonce = maining.MainingRun(blockchain.block[blockNumber - 1].blockTxt, howManyZeros, maximumNumberOfAttempts);
            stopWatch.Stop();
            blockchain.block[blockNumber - 1].blockTxt.nonce = nonce;
            info[blockNumber - 1].nonce = Convert.ToInt32(nonce);
            info[blockNumber - 1].Milliseconds = Convert.ToInt32(stopWatch.ElapsedMilliseconds);
            stopWatch.Reset();
            info[blockNumber - 1].SetInfo();
            ResetData();
            resetInfo.Invoke();
            // */
        }
        public void MainingStartAllBlocks()                 //mainingo visus blokus
        {
            /*
            Task task = Task.Run(() =>
            {
                for (int i = 0; i < blockchain.block.Length; i++)
                {
                    if (!blockchain.block[i].status)  // Ja bloks jau satur vajadzīgo hes summu tad to nesūta uz mainingu
                    {
                        stopWatch.Start();
                        string nonce = maining.MainingRun(blockchain.block[i].blockTxt, howManyZeros, maximumNumberOfAttempts);
                        stopWatch.Stop();

                        blockchain.block[i].blockTxt.nonce = nonce;
                        info[i].nonce = Convert.ToInt32(nonce);
                        info[i].Milliseconds = Convert.ToInt32(stopWatch.ElapsedMilliseconds);
                        stopWatch.Reset();
                        info[i].SetInfo();
                        ResetData();
                    }
                    // ResetData();
                    resetInfo.Invoke();
                }
            }

            );
            task.Wait();
            */
            
            for (int i = 0; i < blockchain.block.Length; i++)
            {
                if (!blockchain.block[i].status)  // Ja bloks jau satur vajadzīgo hes summu tad to nesūta uz mainingu
                {
                    stopWatch.Start();
                    string nonce = maining.MainingRun(blockchain.block[i].blockTxt, howManyZeros, maximumNumberOfAttempts);
                    stopWatch.Stop();

                    blockchain.block[i].blockTxt.nonce = nonce;
                    info[i].nonce = Convert.ToInt32(nonce);
                    info[i].Milliseconds = Convert.ToInt32(stopWatch.ElapsedMilliseconds);
                    stopWatch.Reset();
                    info[i].SetInfo();
                    ResetData();
                }
                // ResetData();
                resetInfo.Invoke();
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
            for (int i = 0; i < blockchain.block.Length; i++)
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
            }
            else if (!a)
            {
                MessageBox.Show("Tika ievadīts nepareizs simbols", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return answer;
        }


    }
}
