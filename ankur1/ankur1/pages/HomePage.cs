using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ankur1.utilities;
using OpenQA.Selenium;

namespace ankur1.pages
{
    public class HomePage
    {
        public void GoToTMPage(IWebDriver driver)
        {
            // identify Administration and click 
            IWebElement AdministrationText = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            AdministrationText.Click();
            wait.WaitToBeClickable(driver, "XPath","/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 7);


            // identify Time & Materials and click
            IWebElement TMText = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            TMText.Click();
            Thread.Sleep(3000);

        }
    }
}
