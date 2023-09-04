using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;

namespace Foody_UI_Testing_WebDriver
{
    public class LoginwithregistrationTest
    {
        private IWebDriver driver;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
        }
        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }
        [Test]
        public void loginwithregistration()
        {
            driver.Navigate().GoToUrl("http://softuni-qa-loadbalancer-2137572849.eu-north-1.elb.amazonaws.com:85/");
            driver.Manage().Window.Size = new System.Drawing.Size(1936, 1056);
            driver.FindElement(By.CssSelector(".nav-item:nth-child(2) > .nav-link")).Click();
            driver.FindElement(By.Id("username")).Click();
            driver.FindElement(By.Id("username")).SendKeys("flower");
            driver.FindElement(By.Id("password")).Click();
            driver.FindElement(By.Id("password")).SendKeys("123456");
            {
                var element = driver.FindElement(By.CssSelector(".pt-1"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).ClickAndHold().Perform();
            }
            {
                var element = driver.FindElement(By.CssSelector(".btn-primary"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).Release().Perform();
            }
            driver.FindElement(By.CssSelector(".pt-1")).Click();
            driver.FindElement(By.CssSelector(".btn-primary")).Click();
            driver.FindElement(By.CssSelector(".masthead-subheading")).Click();
            Assert.That(driver.FindElement(By.CssSelector(".masthead-subheading")).Text, Is.EqualTo("Welcome, flower!"));
            driver.FindElement(By.CssSelector(".nav-item:nth-child(2) > .nav-link")).Click();
            Assert.That(driver.FindElement(By.CssSelector(".masthead-subheading")).Text, Is.Not.EqualTo("Welcome, flower!"));
            driver.Close();
        }
        [Test]
        public void loginwithregistration2()
        {
            driver.Navigate().GoToUrl("http://softuni-qa-loadbalancer-2137572849.eu-north-1.elb.amazonaws.com:85/");
            driver.Manage().Window.Size = new System.Drawing.Size(1936, 1056);
            driver.FindElement(By.CssSelector(".nav-item:nth-child(2) > .nav-link")).Click();
            driver.FindElement(By.Id("username")).Click();
            driver.FindElement(By.Id("username")).SendKeys("flower");
            driver.FindElement(By.Id("password")).Click();
            driver.FindElement(By.Id("password")).SendKeys("123456");
            {
                var element = driver.FindElement(By.CssSelector(".pt-1"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).ClickAndHold().Perform();
            }
            {
                var element = driver.FindElement(By.CssSelector(".btn-primary"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).Release().Perform();
            }
            driver.FindElement(By.CssSelector(".pt-1")).Click();
            driver.FindElement(By.CssSelector(".btn-primary")).Click();
            driver.FindElement(By.CssSelector(".masthead-subheading")).Click();
            Assert.That(driver.FindElement(By.CssSelector(".masthead-subheading")).Text, Is.EqualTo("Welcome, flower!"));
            driver.FindElement(By.CssSelector(".nav-item:nth-child(2) > .nav-link")).Click();
            Assert.That(driver.FindElement(By.CssSelector(".masthead-subheading")).Text, Is.Not.EqualTo("Welcome, flower!"));
            driver.Close();
        }
    }
}