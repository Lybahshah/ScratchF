using DocumentFormat.OpenXml.Drawing.Charts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchF
{
    public class Assertion : BasePage
    {

       
        public void LoginAssertion(string ExpectedError,string ActualError)
        {
            string Expected = "Username or password incorrect.";
            string Actual = driver.FindElement(By.XPath("//*[@id='content']")).Text;
            Assert.AreEqual(Expected, Actual);

        }
        public void SearchAssertion()
        {
            string nam = "The Warrior Cat Game";
     string nam2 = driver.FindElement(By.XPath("//*[@id=\"projectBox\"]/div/div/div[1]/div/div/a")).Text;
            
            Assert.AreEqual(nam, nam2);
        }
    }
}
