using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Blockchain_Demo
{
    public class Bloc
    {
        //______________________________________ Jaunais Mēģinājums _________________________________

        public string number { get; set; }
        public string nonce { get; set; }
        public string data { get; set; }
        public string prewHashSumm { get; set; }
        public string hashSumm { get; set; }
        public Bloc(string number)
        {
            this.number = number;
        }



        //______________________________________ vecais Mēģinājums _________________________________
        
        /*
        SHA256 sha256;// = new SHA256CryptoServiceProvider();
        private byte[] result; // masīvs kurā glabājas atbilde hash summs
        public string answer { get; set; }  // Pārvērst atbilde string formā
        private byte[] data;
        public Bloc(string number)
        {
            this.number = number;                                 // pie izveidošanas iestata numuru kas atbilst kārtas numuram
            sha256 = new SHA256CryptoServiceProvider();
            maximumattempts = 1000000;

        }
        //_________________________________ GetSha256() _____________________________________
        private void GetSha256()
        {
            this.result = sha256.ComputeHash(data);
            
            for (int i = 0; i < result.Length; i++)
            {
                answer = answer + Convert.ToString(result[i], toBase: 16);
            }
        }
        //_____________________________________________________________________________________
        public void ResetData(MainingAnswer answer)
        {
            hashSum = answer.answerHeshSumm;
            Nonce = answer.nonce;

        }
        //_____________________________________________________________________________________
        private void FormatData()   // sagatavo datus prikš hesh summas nemot no winformas bloka
        {
            string dataString = number + Nonce + textt + previousHashSum + hashSum;
            byte[] answer = new byte[dataString.Length];
            for (int i = 0; i < dataString.Length; i++)
            {
                answer[i] = Convert.ToByte(dataString[i]);
            }
            this.data = answer;
        }
        //_____________________________________________________________________________________

        //_____________________________________________________________________________________
        public void Main()
        {
            FormatData();
        }

        //____________________ Iestatījumu sadaļa  _____________________________
        public int howZeros { get; set; }           // Cik nulles vajag
        public int maximumattempts { get; set; }    // maksimālie mejģinājumu skaits
        //____________________ Informācījas sadaļa _____________________________

        public int howZerosInfo { get; set; }       // cik iestatitas nulles
        public int maximumattemptsInfo { get; set; }// cik iestatīti meijģinājumi
        //___ pievienot kas parāda cik laiku aizņēma šim blokam
        //___ pievieno kas parāda cik laiku aizņēma šim un iepriekšējiem blokiem
        //--- pievienot labāko rezultātu ja nesanāca atrast rezultātu dēļ maksimāliem meiģinājumiem
        */
    }
}
