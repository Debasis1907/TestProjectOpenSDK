using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;
using TestProject.OpenSDK.Drivers.Web;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace TestProjectOpenSDK
{
    public class Tests
    {
        private IWebDriver Driver;
        private string token = "EdhxZuoYvHhwNX-JHeVo9Lp_u4Y80hCYRTUTsbXn-mY1";
        [SetUp]
        public void Setup()
        {
            //new DriverManager().SetUpDriver(new ChromeConfig());
            Driver = new ChromeDriver(null,token);
            Driver.Url = "http://eaapp.somee.com";
            Thread.Sleep(5000);
            Driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            Driver.FindElement(By.LinkText("Login")).Click();
            Driver.FindElement(By.Id("UserName")).SendKeys("admin");
            Driver.FindElement(By.Id("Password")).SendKeys("password");
            Driver.FindElement(By.CssSelector(".btn-default")).Click();
            
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Close();
        }
    }
}