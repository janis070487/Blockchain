using System;

namespace Blockchain_Demo
{
    public class Blockchain
    {

        public Block[] block { get; set; }

        public Blockchain(int how)
        {
            block = new Block[how];
            for (int i = 0; i < block.Length; i++)
            {
                block[i] = new Block();
                block[i].blockTxt.number = Convert.ToString(i + 1); // katra bloka number laukā ieraksta attiecīgo numuru
            }
        }

    }
}