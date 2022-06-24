using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Blockchain_Demo;
using System.Diagnostics;
namespace Blockchain_V3._0
{
    public class CoreWinForm : ICore
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
        public ResetInfo resetInfo { get; set; }

        public CoreWinForm(int howBlock)
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
       public void Main(int blockNumber)      // Palaiz lai maina konkreto bloku
        {/*
            stopWatch.Start();
            string nonce = maining.MainingRun(blockchain.block[blockNumber - 1].blockTxt, howManyZeros, maximumNumberOfAttempts);
            stopWatch.Stop();
            blockchain.block[blockNumber - 1].blockTxt.nonce = nonce;
            info[blockNumber - 1].nonce = Convert.ToInt32(nonce);
            info[blockNumber - 1].Milliseconds = Convert.ToInt32(stopWatch.ElapsedMilliseconds);
            stopWatch.Reset();
            info[blockNumber - 1].SetInfo();
            ResetData();
            resetInfo.Invoke();*/
        }

      public  void MainAll(int howBlocv = 0)  // Palaiž lai maina ar noradi ar kuru bloku sākt ja netiek noradīts tad sak ar pirmo
        {/*
            for (int i = howBlocv; i < blockchain.block.Length; i++)
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
            }*/
        }

        public void ResetData() 
        {/*
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
            */
        }
        public void Check(int how) 
        {/*
            for (int i = 0; i < blockchain.block.Length; i++) //Pārbauda katru bloku vai atbilst vajadzīgajam paveiktajam darbam
            {
                blockchain.block[i].status = CheckBlock.Check(how, blockchain.block[i].blockTxt.hashSum);
            }*/
        }
        public int CheckValue(string sms)    // PArbaudis vai tika ievadits korekts skaitlis lauka
        {/*
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
            return answer;*/
            return 0;
        }
        public void LoadFirstDataInBloc()   // Ielādes pirmos datus
        {
          //  blockchain.block[0].blockTxt.prewHashSum = "0000000000000000000000000000000000000000000000000000000000000000";
           // for (int i = 0; i < blockchain.block.Length; i++)
           // {
           //     blockchain.block[i].SetData();       // Sagatavo visus datus
           // }
            MainAll();
            resetInfo.Invoke();                      // Notikums atjauno monitoru
            
        }
        public void ChangedNumber(string numberBloc, string sms)
        {
           // ChangedNumber(Int32.Parse(numberBloc), sms);
        }
        public void ChangedNumber(int numberBloc, string sms)
        {
           // blockchain.block[numberBloc].blockTxt.number = sms;
         //   ResetData();
         //   resetInfo.Invoke();
        }
        public void ChangedNonce(string numberBloc, string sms)
        {
           // ChangedNonce(Int32.Parse(numberBloc), sms);
        }
        public void ChangedNonce(int numberBloc, string sms)
        {
           // blockchain.block[numberBloc].blockTxt.nonce = sms;
          //  ResetData();
          //  resetInfo.Invoke();
        }
        public void ChangedData(string numberBloc, string sms)
        {
           // Changeddata(Int32.Parse(numberBloc), sms);
        }
        public void Changeddata(int numberBloc, string sms)
        {
            //blockchain.block[numberBloc].blockTxt.data = sms;
           // ResetData();
          //  resetInfo.Invoke();
        }
    }
}
