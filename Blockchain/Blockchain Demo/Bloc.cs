using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockchain_Demo
{
     class Bloc
    {
        public int number { get; set; }
        public int Nonce { get; set; }
        public string text { get; set; }
        private byte[] data;
        public string hashSum { get; }
        public string previousHashSum { get; }
        public Bloc()
        {
            maximumattempts = 1000000;

        }
        private void FormatData()
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
