using AutoIt;
using DocumentFormat.OpenXml.Bibliography;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Data;
using System.Drawing;
using System.Reflection.Metadata;
using System.Threading;
using System.Web.ModelBinding;

using System.Windows;

namespace ScratchF
{
    public class Form : BasePage
    {
        By form = By.XPath("//*[@id='footer']/div/div/dl[1]/dd[7]/a");
        By SQA = By.XPath("//*[@id=\"jobs-list\"]/li[1]/a");
        By E1 = By.Id("applicant_first_name");
        By E2 = By.Id("applicant_last_name");
        By E3 = By.Id("applicant_email");
        By E4 = By.Id("applicant_address");
        By E5 = By.Id("applicant_city");
        By E6 = By.Id("applicant_state");
        By E7 = By.Id("applicant_postal");
        By E8 = By.Id("applicant_phone");
        By E9 = By.Id("applicant_resumes_resume");
        By E10 = By.Id("applicant_linkedin");
        
        By E12 = By.Id("applicant_desired_salary");
        By E13 = By.Id("response");
        By E14 = By.XPath("/html/body/div/section/div/div[2]/aside/form/div[12]/div[2]/div[2]/label/label/input");
        By E15 = By.XPath("/html/body/div/section/div/div[2]/aside/form/div[12]/div[3]/div[2]/label/label/input");
        By E16 = By.XPath("/html/body/div/section/div/div[2]/aside/form/div[12]/div[4]/input[3]");
        By E17 = By.Id("applicant_gender_female");
        By E18 = By.Id("applicant_ethnicity_asian");
        By E19 = By.Id("applicant_veteran_status__I_decline_to_state_my_veteran_status");
        By E20 = By.Id("applicant_disability_status_no_i_dont_have_a_disability_or_a_historyrecord_of_having_a_disability");
        By E21 = By.Id("apply_candidate");
        By E22 = By.XPath("/html/body/div/section/div/div[2]/aside/form/div[12]/div[3]/div[2]/label/label/input");
    
        public void FormFill(string e1,string e2,string e3,string e4,string e5,string e6,string e7,string e8,string e9,string e10,string e11)
        {

            Actions act = new Actions(driver);
            IJavaScriptExecutor ex = (IJavaScriptExecutor)driver;
            ex.ExecuteScript("window.scrollBy(0,document.body.scrollHeight)", "");
            driver.FindElement(form).Click();
            //((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("Test3.png", ScreenshotImageFormat.Png);

            driver.SwitchTo().Frame(0);
            IWebElement sqa = driver.FindElement(SQA);
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", sqa);
             ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("Test4.png", ScreenshotImageFormat.Png);
            sqa.Click();
            System.Threading.Thread.Sleep(1000);

            driver.SwitchTo().Window(driver.WindowHandles[1]);

            
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(E1).SendKeys(e1);
            driver.FindElement(E2).SendKeys(e2);
            driver.FindElement(E3).SendKeys(e3);
            driver.FindElement(E4).SendKeys(e4);
            driver.FindElement(E5).SendKeys(e5);
            driver.FindElement(E6).SendKeys(e6);
            driver.FindElement(E7).SendKeys(e7);
            driver.FindElement(E8).SendKeys(e8);
            driver.FindElement(E9).SendKeys(e9);
            Thread.Sleep(3000); 
            
            
           
            driver.FindElement(E12).SendKeys(e10);
            driver.FindElement(E13).SendKeys(e11);
            IWebElement element14 = driver.FindElement(E14);
            act.Click(element14).Perform();
            IWebElement element15 = driver.FindElement(E15);
            act.Click(element15).Perform();
           
            
            
            IWebElement element17 = driver.FindElement(E17);
            act.Click(element17).Perform();
            IWebElement element18 = driver.FindElement(E18);
            act.Click(element18).Perform();
            IWebElement element19 = driver.FindElement(E19);
            act.Click(element19).Perform();
            IWebElement element20 = driver.FindElement(E20);
            act.Click(element20).Perform();
            IWebElement element21 = driver.FindElement(E21);
            act.Click(element21).Perform();
            ////IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            ////js.ExecuteScript("arguments[0].scrollIntoView(true);", element14);
            ////IWebElement element15 = driver.FindElement(By.XPath("/html/body/div/section/div/div[2]/aside/form/div[12]/div[3]/div[2]/label/label/input"));
            ////element15.Click();
            //driver.Quit();
        }
    }
    }
