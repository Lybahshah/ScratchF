using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchF
{
    public class LoginSecond:BasePage
    {
        
        //By SignInFeature = By.XPath("//*[@id='navigation']/div/ul/li[8]/a");
        By Username = By.Id("id_username");
        By Password = By.Id("id_password");
        By Captcha = By.Id("recaptcha-anchor");
        By SignInBtn = By.XPath("//*[@id='content']/form/button");
        By NeedHelpLink = By.XPath("//*[@id='navigation']/div/ul/li[8]/div/div/form/div[3]/a");

       

        public void TypeUserName(string username)
        {
            driver.FindElement(Username).SendKeys(username);


        }
        public void TypePassword(string password)
        {
            driver.FindElement(Password).SendKeys(password);
        }
        public void recaptcha()
        {
            driver.FindElement(Captcha).Click();

        }
        public void ClickLogin()
        {
            driver.FindElement(SignInBtn).Click();

        }
    }
}
