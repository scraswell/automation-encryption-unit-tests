using NUnit.Framework;
using System;

namespace Craswell.Encryption.UnitTests
{
    [TestFixture()]
    public class AesEncryptionToolTests
    {
        [Test()]
        public void AesEncryptionTool_CanEncryptAndDecryptText()
        {
            const string teststring = "Hello world!";
            const string passphrase = "The quick brown fox jumps over the lazy dog.";

            AesEncryptionTool tool = new AesEncryptionTool();

            string ciphertext = tool.EncryptText(teststring, passphrase);
            Assert.AreNotEqual(teststring, ciphertext);

            string decryptedText = tool.DecryptText(ciphertext, passphrase);
            Assert.AreEqual(teststring, decryptedText);
        }

        [Test()]
        public void AesEncryptionTool_CanEncryptAndDecryptInteger()
        {
            const int testinteger = 42;
            const string passphrase = "The quick brown fox jumps over the lazy dog.";

            AesEncryptionTool tool = new AesEncryptionTool();

            string ciphertext = tool.EncryptInt(testinteger, passphrase);
            Assert.AreNotEqual(testinteger, ciphertext);

            int decryptedInteger = tool.DecryptInt(ciphertext, passphrase);
            Assert.AreEqual(decryptedInteger, testinteger);
        }
    }
}

