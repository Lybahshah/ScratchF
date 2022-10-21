using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsInput.Native;

using WindowsInput;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using AutoIt;

namespace ScratchF
{
    public class LoginFirst:BasePage
    {
        InputSimulator sim = new InputSimulator();
        By SignInFeature = By.XPath("//*[@id='navigation']/div/ul/li[8]/a");
        By Username = By.Id("frc-username-1088");
        By Password = By.Id("frc-password-1088");
        By SignInBtn = By.XPath("//*[@id='navigation']/div/ul/li[8]/div/div/form/div[3]/button");
        By NeedHelpLink = By.XPath("//*[@id='navigation']/div/ul/li[8]/div/div/form/div[3]/a");

       
        public void Autoit(string name,string pass)

        {
            Thread.Sleep(1000); 
            AutoItX.WinWait("https://scratch.mit.edu/", "", 2);

            AutoItX.WinActivate("https://scratch.mit.edu/");

            AutoItX.Send("{TAB 9}"); Thread.Sleep(1000);


            AutoItX.Send("{ENTER}");




            AutoItX.Send("{TAB}", 0);

            //AutoItX.Send("lybahshah00");
            AutoItX.Send(name);
            AutoItX.Send("{TAB}", 0);

            //AutoItX.Send("alidaan12");
            AutoItX.Send(pass);
            AutoItX.Send("{TAB}", 0);
            AutoItX.Send("{ENTER}");
            Thread.Sleep(1000);

        }
        public void ClickSignInFeature()
        {
            
            driver.FindElement(SignInFeature).Click();
        }
        public void TypeUserName(string username)

        {
            int i;
            for (i = 1; i < 10; i++)
            {


               
                sim.Keyboard.KeyPress(VirtualKeyCode.TAB);
            }


                sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
            sim.Keyboard.KeyPress(VirtualKeyCode.TAB);
            sim.Keyboard.TextEntry(username);
            

            


        }
        public void TypePassword(string password)
        {
            driver.FindElement(Password).SendKeys(password);
        }
        public void ClickLogin()
        {
            driver.FindElement(SignInBtn).Click();

        }
        public void ClickEnter()
        {
            driver.FindElement(SignInBtn).SendKeys(Keys.Enter);
        }
        //public void ForgotPassword()
        //{
        //    driver.FindElement(NeedHelpLink).Click();
        //}
    }
}
