using AutoIt;
using DocumentFormat.OpenXml.Bibliography;
using OpenQA.Selenium;  
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Drawing;
using System.Reflection.Metadata;
using System.Threading;
using System.Web.ModelBinding;

using System.Windows;

namespace ScratchF
{
    public class CreatePage : BasePage
    {
       
        By CreateaFeature = By.XPath("//*[@id=\"navigation\"]/div/ul/li[2]/a");
        By Tuto = By.XPath("//*[@id=\"app\"]/div/div[1]/div/div/div[1]/div[3]/div[2]");
        By Move = By.XPath("//*[@data-id='motion_goto']");//*[local-name()='g' and @data-id='motion_movesteps'].");
        By Looks = By.XPath("//*[contains(@class,'looks')]");
        By HelloSecond = By.XPath("//*[@data-id='looks_sayforsecs']");
        By Events = By.XPath("//*[contains(@class,'events')]");
        By Flag = By.XPath("//*[@data-id='event_whenflagclicked']");
        By Motion = By.XPath("//*[contains(@class,'motion')]");

        By Control = By.XPath("//*[contains(@class,'control')]");
        By forever = By.XPath("//*[@data-id='forever']");
        public void Mod()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(Tuto)).Click();
        }
        public void ClickonCreateFeature()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

            IWebElement e = wait.Until(ExpectedConditions.ElementIsVisible(CreateaFeature));
            e.Click();
        }
        public void Event()
        {
            IWebElement LocatorTo = driver.FindElement(By.XPath("//*[@class='blocklyMainBackground']"));
            

                                            
                driver.FindElement(Events).Click();
            IWebElement elm = driver.FindElement(Flag);

            Actions actions = new Actions(driver);
            Point point = elm.Location;
            int xcord = point.X;
            int ycord = point.Y;
            actions.MoveToElement(elm)


            .ClickAndHold(elm)
            .Pause(TimeSpan.FromSeconds(3))

          //.MoveByOffset(210,70).
          .MoveByOffset(240, 100)



            .Pause(TimeSpan.FromSeconds(3))
            .Release().Click().Build().Perform();

            Console.WriteLine(AutoItX.MouseGetPos());

        }
        public void ClickonMotionBlock()
        {

                                    
               

            
            driver.FindElement(Motion).Click();


            IWebElement LocatorFrom = driver.FindElement(Move);
            IWebElement LocatorTo = driver.FindElement(By.XPath("//*[@class='blocklyMainBackground']"));
            

            Actions actions = new Actions(driver);
            Point point = LocatorFrom.Location;
            int xcord = point.X;
            int ycord= point.Y;
            actions.MoveToElement(LocatorFrom)
           .Pause(TimeSpan.FromSeconds(3))
                        .ClickAndHold(LocatorFrom)
                        .Pause(TimeSpan.FromSeconds(3))
                        //.MoveByOffset(260,20)
          .MoveByOffset(270,40)


                        .Pause(TimeSpan.FromSeconds(3))
                        .Release().Build().Perform();
           
        }

        public void Bylooks()
        {
            IWebElement LocatorTo = driver.FindElement(By.XPath("//*[@class='blocklyMainBackground']"));


            driver.FindElement(Looks).Click();
            IWebElement el = driver.FindElement(HelloSecond);

            Actions actions = new Actions(driver);
            Point point = el.Location;
            int xcord = point.X;
            int ycord = point.Y;
            actions.MoveToElement(el)


            .ClickAndHold(el)
            .Pause(TimeSpan.FromSeconds(3))
            //.MoveToElement(LocatorTo)

            //.MoveByOffset(xcord + 170, ycord +10)
            .MoveByOffset(xcord + 170, ycord - 20)
            .Pause(TimeSpan.FromSeconds(3))
            .Release().Build().Perform();

            Console.WriteLine(AutoItX.MouseGetPos());

        }
        public void Loop()
        {
            IWebElement LocatorTo = driver.FindElement(By.XPath("//*[@class='blocklyMainBackground']"));


            driver.FindElement(Control).Click();
            IWebElement element = driver.FindElement(forever);
            Actions actions = new Actions(driver);
            Point point = element.Location;
            int xcord = point.X;
            int ycord = point.Y;
            actions.MoveToElement(element)


            .ClickAndHold(element)
           .Pause(TimeSpan.FromSeconds(3))
           .MoveByOffset(220,20)
           
            

           .Pause(TimeSpan.FromSeconds(3))
            .Release()
           .Build().Perform();

        }


    }
}

