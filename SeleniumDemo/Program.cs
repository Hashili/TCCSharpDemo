using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumDemo
{
    class Program
    {
        IWebDriver driver = new ChromeDriver();

        static void Main(string[] args)
        {

        }

        [SetUp]
        public void StartUp()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [Test]
        public void TestOne()
        {
            driver.FindElement(By.Name("UserName")).SendKeys("FromCsharpProj");
            driver.FindElement(By.Name("Password")).SendKeys("FromCsharpProj");
            driver.FindElement(By.XPath("//input[@name='Login']")).Click();
            Console.WriteLine("Logged User In!");
            new SelectElement(driver.FindElement(By.Id("TitleId"))).SelectByText("Ms.");
        }

        [TearDown]
        public void CleanUp()
        {
            Thread.Sleep(5000);
            driver.Quit();
        }

    }
}
