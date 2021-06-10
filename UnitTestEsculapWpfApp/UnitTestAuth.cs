using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using EsculapWpfApp;
using EsculapWpfApp.WindowsAp;
using EsculapWpfApp.ModelBD;
using System.Data.Entity;

namespace UnitTestEsculapWpfApp
{

    [TestClass]
    public class UnitTestAuth
    {
        public static EsculapWpfApp.ModelBD.DataBase dataB = new DataBase();
        

        [TestMethod]
        public void AuthTest()
        {
            
            Assert.IsTrue(WindowLogin.Auth("solnishko", "luchik"));
            Assert.IsTrue(WindowLogin.Auth("rassvet", "tuchka"));
            Assert.IsTrue(WindowLogin.Auth("konovalov", "123qrte"));
            Assert.IsTrue(WindowLogin.Auth("dolinalarisa", "mchs123"));
        }
    }

    [TestClass]

    public class UnitTestAuthError
    {
        

        [TestMethod]

        public void AuthTest()
        {
            
            Assert.IsFalse(WindowLogin.Auth("solnishko", "solnishko"));
            Assert.IsFalse(WindowLogin.Auth("rassvet", "rassvet"));
            Assert.IsFalse(WindowLogin.Auth("konovalov", "konovalov"));
            Assert.IsFalse(WindowLogin.Auth("dolinalarisa", "dolinalarisa"));
            Assert.IsFalse(WindowLogin.Auth("", ""));
            Assert.IsFalse(WindowLogin.Auth(" ", ""));
            Assert.IsFalse(WindowLogin.Auth("", " "));
            Assert.IsFalse(WindowLogin.Auth(" ", " "));
            Assert.IsFalse(WindowLogin.Auth("^^", "&&"));
            Assert.IsFalse(WindowLogin.Auth("^^", "^^"));
        }
    }
}
