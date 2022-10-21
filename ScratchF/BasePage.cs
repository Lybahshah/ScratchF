using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace ScratchF
{
    [TestClass]
    public class BasePage
    {


        public static log4net.ILog Log =

log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType); 
        public static IWebDriver driver;

        public void SeleniumInit()
        {
            IWebDriver ChromeDriver = new ChromeDriver();
            driver = ChromeDriver;
            driver.Url = "https://scratch.mit.edu/";
            driver.Manage().Window.Maximize();
            Log.Info("Browser is opened");
        }
        public void SeleniumInit2()
        {
            //IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://scratch.mit.edu/login_retry/");

        }
        public void SeleniumInit3()
        {
            //IWebDriver driver = new ChromeDriver();
           
            driver.SwitchTo().Frame(1);
            
           

        }
        public void SeleniumInit4()
        {
            driver.SwitchTo().DefaultContent();
        }
        public void SeleniumInit5()
        {
            WebDriverWait wait = (WebDriverWait)driver;
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id=\"navigation\"]/div/ul/li[9]/div/a/span")));
        }

        
    }
}
