using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeBitcoin.Blockchain;

namespace EncryptionTest
{
    [TestClass]
    public class EncryptionTest
    {
        [TestMethod]
        public void CheckIfStringIsReturned()
        {
            EncryptionLogic eLog = new EncryptionLogic(1);
            Assert.IsNotNull(eLog.HashData("Test"));
        }
    }
}
