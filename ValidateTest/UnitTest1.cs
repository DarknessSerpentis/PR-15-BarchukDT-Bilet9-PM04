using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PR_15_BarchukDT_Bilet9_PM04;

namespace ValidateTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string wrongtext = "ghj";
            string goodtext = "ghjklg";
            Assert.IsFalse(PR_15_BarchukDT_Bilet9_PM04.MainWindow.LoginValidate(wrongtext));
            Assert.IsTrue(PR_15_BarchukDT_Bilet9_PM04.MainWindow.LoginValidate(goodtext));
        }

        [TestMethod]
        public void TestMethod2()
        {
            string wrongtext = "ghj";
            string goodtext = "ghjklgfdghfwfd";
            Assert.IsFalse(PR_15_BarchukDT_Bilet9_PM04.MainWindow.PasswordValidate(wrongtext));
            Assert.IsTrue(PR_15_BarchukDT_Bilet9_PM04.MainWindow.PasswordValidate(goodtext));
        }
    }
}
