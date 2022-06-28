using System;
using System.Windows.Forms;
using Blockchain_Demo;
using System.Diagnostics;

namespace Blockchain_V3._0
{
    public class CoreWinForm : ICore
    {
        public Blockchain blockchain { get; set; }
        private Sha256FromBlocData sha256FromBlock;
        private Maining maining;
        private Stopwatch sw;
        public Info[] info { get; set; }
        public int howManyZeros { get; set; }
        public int maximumNumberOfAttempts { get; set; }
        public delegate void ResetInfo();
        public delegate void ResetNonce();
        public ResetInfo resetInfo { get; set; }
        public ResetNonce resetNonce { get; set; }
        public CoreWinForm(int howBlock)
        {
            blockchain = new Blockchain(howBlock);
            sha256FromBlock = new Sha256FromBlocData();
            sw = new Stopwatch();
            maining = new Maining();
            info = new Info[howBlock];
            for (int i = 0; i < howBlock; i++)
            {
                info[i] = new Info();
            }
        }
        public void Maining(int blockNumber)      // Palaiz lai maina konkreto bloku
        {
            sw.Start();
            string nonce = maining.MainingRun(blockchain.block[blockNumber].blockTxt, howManyZeros, maximumNumberOfAttempts);
            sw.Stop();
            blockchain.block[blockNumber].blockTxt.nonce = nonce;
            info[blockNumber].nonce = Convert.ToInt32(nonce);
            info[blockNumber].Milliseconds = Convert.ToInt32(sw.ElapsedMilliseconds);
            info[blockNumber].SetInfo();
            sw.Reset();
            blockchain.block[blockNumber].blockTxt.hashSum = GetHexToByte.GetHex(sha256FromBlock.GetSha256(blockchain.block[blockNumber].blockdata));
            ResetAllBlock();
            resetInfo.Invoke();
            resetNonce.Invoke();
        }

        public void MainAll(int howBlocv = 0)  // Palaiž lai maina ar noradi ar kuru bloku sākt ja netiek noradīts tad sak ar pirmo
        {
            for (int i = howBlocv; i < blockchain.block.Length; i++)
            {
                sw.Start();
                string nonce = maining.MainingRun(blockchain.block[i].blockTxt, howManyZeros, maximumNumberOfAttempts);
                sw.Stop();
                blockchain.block[i].blockTxt.nonce = nonce;
                info[i].nonce = Convert.ToInt32(nonce);
                info[i].Milliseconds = Convert.ToInt32(sw.ElapsedMilliseconds);
                sw.Reset();
                info[i].SetInfo();
                blockchain.block[i].blockTxt.hashSum = GetHexToByte.GetHex(sha256FromBlock.GetSha256(blockchain.block[i].blockdata));
                if (i + 1 < blockchain.block.Length)
                {
                    blockchain.block[i + 1].blockTxt.prewHashSum = blockchain.block[i].blockTxt.hashSum;
                }
                ResetAllBlock();
                resetInfo.Invoke();
                resetNonce.Invoke();
            }
        }
        public void Check(int how)
        {
            for (int i = 0; i < blockchain.block.Length; i++) //Pārbauda katru bloku vai atbilst vajadzīgajam paveiktajam darbam
            {
                blockchain.block[i].status = CheckBlock.Check(how, blockchain.block[i].blockTxt.hashSum);
            }
        }
        public bool CheckValue(string sms, out string val)    // PArbaudis vai tika ievadits korekts skaitlis lauka
        {
            try
            {
                int answer = Convert.ToInt32(sms);
                val = sms;
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Ievadītajā skaitlī ir neatļauts simbols", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Ievadītais skaitlis ir par lielu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            val = "0";
            return false;
        }
        public void LoadFirstDataInBloc()   // Ielādes pirmos datus
        {
            blockchain.block[0].blockTxt.prewHashSum = "0000000000000000000000000000000000000000000000000000000000000000";
            for (int i = 0; i < blockchain.block.Length; i++)
            {
                blockchain.block[i].SetData();   // visus text(string) apvieno un parstata  visu byte masiva
                sw.Start();
                string nonce = maining.MainingRun(blockchain.block[i].blockTxt, howManyZeros, maximumNumberOfAttempts); // atgriez uzdevuma rezultatu
                sw.Stop();
                blockchain.block[i].blockTxt.nonce = nonce; // maininga atbildi ieraksta objekta
                info[i].nonce = Convert.ToInt32(nonce);
                info[i].Milliseconds = Convert.ToInt32(sw.ElapsedMilliseconds);
                sw.Reset();
                info[i].SetInfo();
                blockchain.block[i].SetData();
                blockchain.block[i].blockTxt.hashSum = GetHexToByte.GetHex(sha256FromBlock.GetSha256(blockchain.block[i].blockdata));
                if (i + 1 < blockchain.block.Length)
                {
                    blockchain.block[i + 1].blockTxt.prewHashSum = blockchain.block[i].blockTxt.hashSum;
                }
                blockchain.block[i].status = CheckBlock.Check(howManyZeros, blockchain.block[i].blockTxt.hashSum);
            }
        }
        public bool ChangedNumber(string numberBloc, string sms)
        {
            bool met = CheckValue(sms, out sms);
            ChangedNumber(Int32.Parse(numberBloc), sms);
            return met;
        }
        public bool ChangedNumber(int numberBloc, string sms)
        {
            blockchain.block[numberBloc].blockTxt.number = sms;
            ResetAllBlock();
            resetInfo.Invoke();
            return true;
        }
        public void ChangedNonce(string numberBloc, string sms)
        {
            ChangedNonce(Int32.Parse(numberBloc), sms);
        }
        public void ChangedNonce(int numberBloc, string sms)
        {
            blockchain.block[numberBloc].blockTxt.nonce = sms;
            ResetAllBlock();
            resetInfo.Invoke();
        }
        public void ChangedData(string numberBloc, string sms)
        {
            Changeddata(Int32.Parse(numberBloc), sms);
        }
        public void Changeddata(int numberBloc, string sms)
        {
            blockchain.block[numberBloc].blockTxt.data = sms;
            ResetAllBlock();
            resetInfo.Invoke();
        }

        public void ResetAllBlock()
        {
            for (int i = 0; i < blockchain.block.Length; i++)
            {
                blockchain.block[i].SetData();   // visus text(string) apvieno un parstata  visu byte masiva
                blockchain.block[i].SetData();
                blockchain.block[i].blockTxt.hashSum = GetHexToByte.GetHex(sha256FromBlock.GetSha256(blockchain.block[i].blockdata));
                if (i + 1 < blockchain.block.Length)
                {
                    blockchain.block[i + 1].blockTxt.prewHashSum = blockchain.block[i].blockTxt.hashSum;
                }
                blockchain.block[i].status = CheckBlock.Check(howManyZeros, blockchain.block[i].blockTxt.hashSum);
            }
        }
    }
}
