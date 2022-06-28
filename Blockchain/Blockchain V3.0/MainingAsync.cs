using Blockchain_Demo;
using System;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Blockchain_V3._0
{
    public class MainingAsync
    {
        SHA256 sha256;
        public string nonce { get; }
        public MainingAsync()
        {
            sha256 = new SHA256Managed();
        }
        public string MainingRun(BlockTxt data, int howManyZeros, int maximumNumberOfAttempts, Level level)
        {
            if (level == Level.lov)
            {
                var task1 = Run(data, howManyZeros, maximumNumberOfAttempts, 1, 1);
                var result = Task.WhenAny(task1);
                return Convert.ToString(result);
            }
            else if (level == Level.middle)
            {
                var task1 = Run(data, howManyZeros, maximumNumberOfAttempts, 1, 2);
                var task2 = Run(data, howManyZeros, maximumNumberOfAttempts, 2, 2);
                var result = Task.WhenAny(task1, task2);
                return Convert.ToString(result);
            }
            else
            {
                var task1 = Run(data, howManyZeros, maximumNumberOfAttempts, 1, 3);
                var task2 = Run(data, howManyZeros, maximumNumberOfAttempts, 2, 3);
                var task3 = Run(data, howManyZeros, maximumNumberOfAttempts, 3, 3);
                var result = Task.WhenAny(task1, task2, task3);
                return Convert.ToString(result);
            }
        }
        async Task<int> Run(BlockTxt data, int howManyZeros, int maximumNumberOfAttempts, int number, int participants = 1)
        {
            int nonce = (number - 1) * 1000;
            await Task.Run(() =>
                 {
                     int koicoefficient = participants * 1000;
                     int karta = 1;
                     string shaSum = "";
                     int counter = 0;
                     int nowToWhom;
                     while (counter < maximumNumberOfAttempts)
                     {
                         string sumString = data.number + Convert.ToString(nonce) + data.data + data.prewHashSum; // apvienojam datus
                         byte[] sumData = new byte[sumString.Length];                           //  izveidojam masīvu lai tos parveidotu
                         for (int i = 0; i < sumString.Length; i++)                            // datus parveidojam byte masīvā
                         {
                             sumData[i] = Convert.ToByte(sumString[i]);
                         }
                         //_____________ 1 ________________________________________
                         shaSum = GetHexToByte.GetHex(sha256.ComputeHash(sumData));      // iegustam sha summu un uzreiz rezultātu pārvēršam string hex

                         if (CheckBlock.Check(howManyZeros, shaSum))
                         {
                             break;
                         }
                         if (nonce > karta * koicoefficient)
                         {
                             karta++;
                             nonce = nonce + koicoefficient;
                         }
                         nonce++;
                         counter++;
                     }
                 });
            return nonce;
        }

        async Task PrintNameAsync(string name)
        {
            await Task.Delay(20000);     // имитация продолжительной работы
            Console.WriteLine(name);
        }

    }
}