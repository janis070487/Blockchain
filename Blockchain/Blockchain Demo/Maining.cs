using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace Blockchain_Demo
{
    public class Maining 
    {

        SHA256 sha256;
        public Maining()
        {
            sha256 = new SHA256CryptoServiceProvider();
        }
        public string MainingRun(BlockTxt data, int howManyZeros, int maximumNumberOfAttempts)
        {
            int nonce = 0;
            string shaSum = "";
            int counter = 0;
            while(counter < maximumNumberOfAttempts)
            {
                string sumString = data.number + Convert.ToString(nonce) + data.data + data.prewHashSum; // apvienojam datus
                byte[] sumData = new byte[sumString.Length];                           //  izveidojam masīvu lai tos parveidotu
                for (int i = 0; i < sumString.Length; i++)                            // datus parveidojam byte masīvā
                {
                    sumData[i] = Convert.ToByte(sumString[i]);
                }
                //_____________ 1 ________________________________________
                shaSum = GetHexToByte.GetHex(sha256.ComputeHash(sumData));      // iegustam sha summu un uzreiz rezultātu pārvēršam string hex

                if(CheckBlock.Check(howManyZeros, shaSum))
                {
                    break;
                }
                nonce++;
                counter++;
            }
            
            /*
            1. no mantotā klases iegustam sha summu no data
            2. ar klasi pārbaudam vai atbilst prasibām
            3. ja atbilst tad atgriezam atbilsi
            4. ja ne lauku nonce palielinam par vienu
            5. nonce parveršam 

            */




            return Convert.ToString(nonce);  
        }
    }
}
