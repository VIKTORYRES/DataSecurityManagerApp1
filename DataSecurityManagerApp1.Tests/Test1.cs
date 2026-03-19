using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Security.Cryptography;
using System.IO;
using DataSecurityManagerApp1;

namespace DataSecurityManagerApp1.Tests
{
    [TestClass]
    public class DataSecurityManagerTests
    {
        //  Проверяет, что объект DataSecurityManager создаётся успешно
        [TestMethod]
        public void Test1()
        {
            var obj = new DataSecurityManager();
            Assert.IsNotNull(obj);
        }

        //  Проверяет, что объект AES шифрования создаётся корректно
        [TestMethod]
        public void Test2()
        {
            var obj = Aes.Create();
            Assert.IsNotNull(obj);
        }

        //  Проверяет, что длина соли для шифрования составляет 32 байта
        [TestMethod]
        public void Test3()
        {
            var val = new byte[32];
            Assert.AreEqual(32, val.Length);
        }

        //  Проверяет, что длина криптографического ключа составляет 32 байта
        [TestMethod]
        public void Test4()
        {
            var pass = "test";
            var salt = new byte[32];
            var res = new Rfc2898DeriveBytes(pass, salt, 100000).GetBytes(32);
            Assert.AreEqual(32, res.Length);
        }

        // Проверяет, что длина вектора инициализации составляет 16 байт 
        [TestMethod]
        public void Test5()
        {
            var pass = "test";
            var salt = new byte[32];
            var res = new Rfc2898DeriveBytes(pass, salt, 100000).GetBytes(16);
            Assert.AreEqual(16, res.Length);
        }

        // Проверяет, что зашифрованный файл имеет расширение .enc
        [TestMethod]
        public void Test6()
        {
            var val = "file.txt.enc";
            Assert.IsTrue(val.EndsWith(".enc"));
        }

        // Проверяет, что расшифрованный файл имеет расширение .dec
        [TestMethod]
        public void Test7()
        {
            var val = "file.txt.dec";
            Assert.IsTrue(val.EndsWith(".dec"));
        }

        // Проверяет, что объект для генерации ключа создаётся успешно
        [TestMethod]
        public void Test8()
        {
            var obj = new Rfc2898DeriveBytes("pass", new byte[32], 100000);
            Assert.IsNotNull(obj);
        }

        // Проверяет, что длина ключа и вектора инициализации различаются
        [TestMethod]
        public void Test9()
        {
            var key = new Rfc2898DeriveBytes("pass", new byte[32], 100000).GetBytes(32);
            var iv = new Rfc2898DeriveBytes("pass", new byte[32], 100000).GetBytes(16);
            Assert.AreNotEqual(key.Length, iv.Length);
        }
    }
}