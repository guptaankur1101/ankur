using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace ankur1.pages
{
    public class TM_Page
    {
        public void CreateTimeRecord(IWebDriver driver)
        {
            // Identify Create New Button and click
            IWebElement CreateNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            CreateNewButton.Click();

            // click on TypeCode
            IWebElement dropdownlist = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            dropdownlist.Click();


            IWebElement timeoption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            timeoption.Click();



            //click on Code

            IWebElement CodeTextbox = driver.FindElement(By.Id("Code"));
            CodeTextbox.SendKeys("Ankur1");


            // click on Description 
            IWebElement DescriptionTextbox = driver.FindElement(By.Id("Description"));
            DescriptionTextbox.SendKeys("QWERTY");

            //click on Price per unit
            IWebElement PriceTag = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            PriceTag.Click();

            IWebElement PriceTextbox = driver.FindElement(By.Id("Price"));
            PriceTextbox.SendKeys("11");

            // click on Save button
            IWebElement SaveButton = driver.FindElement(By.Id("SaveButton"));
            SaveButton.Click();
            Thread.Sleep(3500);
            // to test create entry
            IWebElement lastpageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastpageButton.Click();
            Thread.Sleep(6000);

            IWebElement lastentry = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            if (lastentry.Text == "Ankur1")
            {
                Assert.Pass("Entry successfully created");
            }
            else
            {
                Assert.Fail("Entry not created ");
                //in place of if and else--- Assert.That(lastentry.Text =="Ankur1","Entry successfully created");
            }
        }
        public void EditTimeRecord(IWebDriver driver)
        {
            IWebElement EditButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[2]/td[5]/a[1]"));
            EditButton.Click();

            IWebElement DescriptionTextbox = driver.FindElement(By.Id("Description"));
            DescriptionTextbox.Clear();
            DescriptionTextbox.SendKeys("QWERTY");

            IWebElement SaveButton = driver.FindElement(By.Id("SaveButton"));
            SaveButton.Click();
        }
           public void DeleteTimeRecord(IWebDriver driver)
        {
         // create delete functionality
        
        IWebElement DeleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[1]/td[5]/a[2]"));
        DeleteButton.Click();
        Thread.Sleep(3000);

        IAlert confirmationAlert = driver.SwitchTo().Alert();
        confirmationAlert.Accept();
        Thread.Sleep(3000);
        }   
    }
}
