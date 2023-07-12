using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ankur1.pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
using ankur1.utilities;

namespace ankur1.tests
{
    [TestFixture]
    public class TM_Tests: CommonDriver
    {

        [SetUp]
        public void TM_Setup()
        {
            // open chrome browser
            driver = new ChromeDriver();

            // Login Page object initialization and defination 
            loginpage LoginPageObj = new loginpage();
            LoginPageObj.LoginSteps(driver);

            // Home page Object Initialization and defination

            HomePage HomePageObj = new HomePage();
            HomePageObj.GoToTMPage(driver);

        }
        [Test]
        public void CreateTime_Test()
        {

            TM_Page TMPageObj = new TM_Page();
            TMPageObj.CreateTimeRecord(driver);
        }
        [Test]
        public void EditTime_Test()
        {
            TM_Page TMPageObj = new TM_Page();
            TMPageObj.EditTimeRecord(driver);
        }
        [Test]
        public void DeleteTime_Test()
        {
            TM_Page TMPageObj = new TM_Page();
            TMPageObj.DeleteTimeRecord(driver);
        }
        [TearDown]
        public void ClosingSteps()
        {
            driver.Quit();
        }
    }
       

        
       


        

       
}
