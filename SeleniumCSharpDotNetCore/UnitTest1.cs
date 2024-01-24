using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCSharpDotNetCore
{
    public class Tests
    {
        public IWebDriver Driver;


        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");
            Driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://booking.com");
            Driver.FindElement(By.Name("ss")).SendKeys("Grecja");
      
            Console.WriteLine("Test1");
            Assert.Pass();
        }
    }
} 