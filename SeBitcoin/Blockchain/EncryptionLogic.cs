using System;
using System.Collections.Generic;
using System.Text;

namespace SeBitcoin.Blockchain
{
    class EncryptionLogic
    {
        //Nonce is used to mine block
        private int nonce = 0;
        private bool cracked = false;

        //How many zeroes a block needs to start with to be approved
        private int difficulty;

        public EncryptionLogic(int dif)
        {
            difficulty = dif;
        }

        public string HashData(string data)
        {
            return "We'll do this later";
        }

        public string MineBlock(string preBlockHash, string currData)
        {
            //Prefix string creates a new string with amount of zeroes equal to the difficulty level.
            string prefixString = new string(new char[difficulty]).Replace('\0', '0');

            while (!cracked)
            {
                if (this.HashData(preBlockHash + currData + nonce.ToString()).Substring(0, difficulty).Equals(prefixString))
                {
                    cracked = true;
                }
                else
                {
                    nonce++;
                }
            }
            Console.WriteLine(preBlockHash);
            Console.WriteLine(currData);
            Console.WriteLine(nonce);

            return this.HashData(preBlockHash + currData + nonce.ToString());
        }

        public int getNonce()
        {
            return nonce;
        }

        public int getDifficulty()
        {
            return difficulty;
        }
    }
}
