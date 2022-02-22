using SeBitcoin.Blockchain;
using System;
using System.Collections.Generic;

namespace SeBitcoin
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Block> blockChain = new List<Block>();
            blockChain.Add(new Block("0", "Genesis block", 1));
        }

    }
}
