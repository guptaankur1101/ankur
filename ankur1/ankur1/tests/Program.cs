using System.Diagnostics;
using ankur1.pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class Program
{
    private static void Main(string[] args)
    {
        // open chrome browser
        IWebDriver driver = new ChromeDriver();

        // Login Page object initialization and defination 
        loginpage LoginPageObj = new loginpage();
        LoginPageObj.LoginSteps(driver);

        // Home page Object Initialization and defination

        HomePage HomePageObj = new HomePage();
        HomePageObj.GoToTMPage(driver);

        //TM page initialization and defination 

        TM_Page TMPageObj = new TM_Page();
        TMPageObj.CreateTimeRecord(driver);

        TMPageObj.EditTimeRecord(driver);

        TMPageObj.DeleteTimeRecord(driver);










        /*// test if login successfull

        IWebElement hellohari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
        if (hellohari.Text == "Hello hari!")
        {
            Console.WriteLine("user has login in successfully");
        }
        else
        {       
        Console.WriteLine("login fail");
        }
*/


        /*

        //test entry created
        
        IWebElement lastpageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
        lastpageButton.Click();
        Thread.Sleep(6000);

        IWebElement lastentry = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
        if (lastentry.Text == "Ankur1")
        {
            Console.WriteLine("Entry successfully created");
        }
        else
        {
            Console.WriteLine("Entry not created ");
        } 
        
       

        Console.WriteLine("Entry is deleted");*//*


        // edit functionality

       

        Console.WriteLine("Entry is edited successfully");*/

    }
}


