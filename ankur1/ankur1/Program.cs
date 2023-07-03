using System.Diagnostics;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class Program
{
    private static void Main(string[] args)
    {
        // open chrome browser
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();

        //launch turnup portal
        driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

        //identify username textbox and enter valid username
        IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
        usernameTextbox.SendKeys("hari");

        //identify password textbox and enter valid password
        IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
        passwordTextbox.SendKeys("123123");

        // click on login button 
        IWebElement loginbutton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
        loginbutton.Click();

        // test if login successfull

        IWebElement hellohari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
        if (hellohari.Text == "Hello hari!")
        {
            Console.WriteLine("user has login in successfully");
        }
        else
        {       
        Console.WriteLine("login fail");
        }

        // identify Administration and click 
        IWebElement AdministrationText = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
        AdministrationText.Click();

        // identify Time & Materials and click
        IWebElement TMText = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
        TMText.Click();
        
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
        
        // create edit functionality


    }
}


