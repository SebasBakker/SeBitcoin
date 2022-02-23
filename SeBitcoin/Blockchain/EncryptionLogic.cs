using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace SeBitcoin.Blockchain
{
    public class EncryptionLogic
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
            var crypt = new System.Security.Cryptography.SHA256Managed();
            var hash = new System.Text.StringBuilder();
            //Can be changed to 16
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(data));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
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
