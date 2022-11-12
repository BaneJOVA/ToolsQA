using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFirstTask
{
    public class Program
    {
        IWebDriver driver = new ChromeDriver();
        static void Main(string[] args)
        {


        }

        [SetUp]
        public void Inicializacia()
        {
            driver.Navigate().GoToUrl("//www.https://demoqa.com/automation-practice-form/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void ExecuteTest()
        {
            IWebElement firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Bane");

            IWebElement lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Jovanovic");

            IWebElement currentAddress = driver.FindElement(By.Id("currentAddress"));
            currentAddress.SendKeys("Beograd");

        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
           
        }
    }
}
