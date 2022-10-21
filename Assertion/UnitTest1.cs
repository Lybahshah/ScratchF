using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Assertion
{
    [TestClass]
    public class UnitTest1
    {
        string ExpectedError = "Username or password incorrect.";
        string ActualError = driver.FindElement(By.XPath("//*[@id='content']/p")).Text;
        Assert.AreEqual(ExpectedError, ActualError);

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
