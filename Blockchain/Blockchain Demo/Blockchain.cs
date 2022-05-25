using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockchain_Demo
{
    public class Blockchain
    {
        private FirstBlock firstBlock;
        private Bloc[] block;

        public Blockchain(int Howblock)
        {
            firstBlock = new FirstBlock();
            block = new Bloc[Howblock - 1];
           for(int i = 0; i < block.Length; i++)
            {
               block[i] = new Bloc();
            }
          
        }

        public void ResetBlockData(int whereBlockChanges)   // Atjauno datus blokos ja notikusi teksta izmaiņas
        {
            if(whereBlockChanges == 1) // Ja tas ir noticis 1. blokā tad iasauc viņam tikai izmaiņas
            {
                firstBlock.ResetData();
            }
            else // citādi citā bloku masīvā kurā notika iamaiņas
            {
                block[whereBlockChanges - 2].ResetData();
            }
        }

    }
}
