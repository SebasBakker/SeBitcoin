using System;
using System.Collections.Generic;
using System.Text;

namespace SeBitcoin.Blockchain
{
    class Block
    {
        private string previousHash;
        private string blockDataHashed;
        private EncryptionLogic eLog;

        public Block(string preHash, string data, int dif)
        {
            eLog = new EncryptionLogic(dif);
            previousHash = preHash;
            blockDataHashed = eLog.MineBlock(preHash, data);
        }

        public string getPreviousHash()
        {
            return previousHash;
        }

        public string getBlockDataHashed()
        {
            return blockDataHashed;
        }

        public string getBlockDataInString()
        {
            string dif = eLog.getDifficulty().ToString();
            string tries = eLog.getNonce().ToString();
            return " with previous hash: " + this.getPreviousHash() + " and current hash: " + this.getBlockDataHashed() + ", difficulty: " + dif + " tries " + tries;
        }
    }
}
