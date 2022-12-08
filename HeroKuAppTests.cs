using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.ObjectModel;

namespace HerokuAppTests
{
    [TestClass]
    public class HeroKuAppTests
    {
        [TestMethod]
        //[DataRow(11, 11)]
        [DataRow(7, 7)]
        //[DataRow (11, 13)]

        public void AddRemoveFunctionsCorrectlyForOneItem(int clicks, int result)
        {
            //int count = 0;
            ///AAA
            ///arrange
            ChromeDriver _browser = new ChromeDriver();
            //InternetExplorerDriver _browser = new InternetExplorerDriver();
            // RemoteWebDriver _browser = new RemoteWebDriver(new Uri("http://localhost:58424"), new ChromeOptions());
            _browser.Url = "https://the-internet.herokuapp.com";
            Console.WriteLine(_browser.Title);
            ///act

            IWebElement urladdremove = _browser.FindElement(By.XPath("//*[@id=\"content\"]/ul/li[2]/a"));
            urladdremove.Click();

            IWebElement clickadd = _browser.FindElement(By.XPath("//*[@id=\"content\"]/div/button"));
            for (int i = 1; i <= clicks; i++)
            {
                clickadd.Click();
                //count ++;
            }
            ///assert
            ReadOnlyCollection<IWebElement> mydeletcollection = _browser.FindElements(By.XPath("//button[@class='added-manually']"));

            Assert.AreEqual(result, mydeletcollection.Count);
        }




        [TestMethod]
        //[DataRow(11, 0)]
        [DataRow(7,0)]
        //[DataRow (11, 13)]

        public void DeleteFunctionsCorrectlyForOneItem(int clicks, int result)
        {
            //int count = 0;
            ///AAA
            ///arrange
            ChromeDriver _browser = new ChromeDriver();
            //InternetExplorerDriver _browser = new InternetExplorerDriver();
            // RemoteWebDriver _browser = new RemoteWebDriver(new Uri("http://localhost:58424"), new ChromeOptions());
            _browser.Url = "https://the-internet.herokuapp.com";
            Console.WriteLine(_browser.Title);
            ///act

            IWebElement urladdremove = _browser.FindElement(By.XPath("//*[@id=\"content\"]/ul/li[2]/a"));
            urladdremove.Click();

            IWebElement clickadd = _browser.FindElement(By.XPath("//*[@id=\"content\"]/div/button"));
            for (int i = 1; i <= clicks; i++)
            {
                clickadd.Click();
                //count ++;
            }
             ReadOnlyCollection<IWebElement> mydeletcollection = _browser.FindElements(By.XPath("//button[@class='added-manually']"));
             Assert.AreEqual(result, mydeletcollection.Count);
            IWebElement clickdelete = _browser.FindElement(By.XPath("//button[@class='added-manually']"));
            for (int i = 1; i <= clicks; i++)
            {
                clickdelete.Click();
                //count ++;
            }
            ///assert
            ReadOnlyCollection<IWebElement> mydeletcollection = _browser.FindElements(By.XPath("//button[@class='added-manually']"));

            Assert.AreEqual(result, mydeletcollection.Count);




        



    }
    }
}
