using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Blockchain_Demo
{
     class Bloc
    {
        SHA256 sha256;// = new SHA256CryptoServiceProvider();
        private byte[] result; // masīvs kurā glabājas atbilde hash summs
        public string answer { get; set; }  // Pārvērst atbilde string formā
        public int number { get; set; }
        public int Nonce { get; set; }
        public string text { get; set; }
        private byte[] data;
        public string hashSum { get; }
        public string previousHashSum { get;}
        public Bloc()
        {
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
        public void ResetData()
        {

        }
        private void FormatData()   // sagatavo datus prikš hesh summas nemot no winformas bloka
        {

        }
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
    }
}
