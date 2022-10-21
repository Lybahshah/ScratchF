using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchF
{
    public class SignUp:BasePage
    {
        By join = By.XPath("//*[@id=\"view\"]/div/div[2]/div[1]/div[1]/div/a[2]");
        By username = By.XPath("//*[@id='username']");
        By password = By.XPath("//*[@id='password']");
        By cnfrmPass = By.XPath("//*[@id='passwordConfirm']");
        By checkbox = By.Id("showPassword");
        By clickFirst = By.XPath("/html/body/div[2]/div/div/div/form/div/div[2]/button");
        public void ClickOnJoin()
        {
            driver.FindElement(join).Click();
        }
        public void EnterUsername(string Username)
        {
            driver.FindElement(username).SendKeys(Username);

        }
        public void EnterPassword(string Password)
        {
            driver.FindElement(password).SendKeys(Password);
        }
        public void EnterConfrmPass(string Cnfrmpass)
        {
            driver.FindElement(cnfrmPass).SendKeys(Cnfrmpass);
        }
        public void Checkbox()
        {
            driver.FindElement(checkbox).Click();
        }
        public void next()
        {
            driver.FindElement(clickFirst).Click();
        }
    }
}
