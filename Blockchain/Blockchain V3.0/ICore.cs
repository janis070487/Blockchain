﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockchain_V3._0
{
    public interface ICore
    {
        void Main(int howBlocv);    // Palaiz lai maina konkreto bloku
        void MainAll(int howBlocv = 0);  // Palaiž lai maina ar noradi ar kuru bloku sākt ja netiek noradīts tad sak ar pirmo

        void ResetData();
        void Check(int how);          // 
        int CheckValue(string sms);    // PArbaudis vai tika ievadits korekts skaitlis lauka
        void LoadFirstDataInBloc();   // Ielādes pirmos datus
        void ChangedNumber(string numberBloc, string sms); 
        void ChangedNumber(int numberBloc, string sms);
        void ChangedNonce(string numberBloc, string sms);
        void ChangedNonce(int numberBloc, string sms);
        void ChangedData(string numberBloc, string sms);
        void Changeddata(int numberBloc, string sms);
    }
}
