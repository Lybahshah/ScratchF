using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchF
{
    public class Search:BasePage
    {
       
        By search = By.Name("q");
        By SearcBtn = By.XPath("//*[@id=\"navigation\"]/div/ul/li[6]/form/button");

       
        public void searchField(string data)
        {
            driver.FindElement(search).SendKeys(data);
        }
        public void serachButton()
        {
            driver.FindElement(SearcBtn).Click();

        }
        public void enterClick()
        {
            driver.FindElement(SearcBtn).SendKeys(Keys.Enter);
        }
    }
}
