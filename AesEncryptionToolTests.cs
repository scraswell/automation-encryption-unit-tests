using NUnit.Framework;
using System;

namespace Craswell.Encryption.UnitTests
{
    [TestFixture()]
    public class AesEncryptionToolTests
    {
        [Test()]
        public void AesEncryptionTool_CanEncryptAndDecrypt()
        {
            const string teststring = "Hello world!";
            const string passphrase = "The quick brown fox jumps over the lazy dog.";

            AesEncryptionTool tool = new AesEncryptionTool();

            string ciphertext = tool.EncryptText(teststring, passphrase);
            Assert.AreNotEqual(teststring, ciphertext);

            string decryptedText = tool.DecryptText(ciphertext, passphrase);
            Assert.AreEqual(teststring, decryptedText);
        }
    }
}

