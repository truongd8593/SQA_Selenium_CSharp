using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace SeleniumHello
{
    [TestClass]
    public class TruongSQA001
    {
        public IWebDriver driver;

        /*Testing open browser and close it*/

        /************************************************************/
        /* When selecting console application, we need a Main method*/
        /************************************************************/
        //static void Main(string[] args)
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Url = "http://forums.silverfrost.com/viewtopic.php?t=1735&highlight=binary+tree";
        //}
        /***********************************************************/
        /* We shall build dll and run test cases by right click on
         * the source code window -> Run Tests.
         * /
        /***********************************************************/

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void OpenChromeUrl()
        {
            driver.Url = "http://forums.silverfrost.com";
        }

        [TearDown]
        public void MyFinalize()
        {
            driver.Close();
        }
    }

    [TestClass]
    public class TruongSQA002
    {
        IWebDriver driver;
        /* Testing open browser at the address of my Github repositories, then click one of them */
        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void ClickRepo()
        {
            driver.Url = "https://github.com/truongd8593";

            const int timeoutSeconds = 15;
            var ts = new TimeSpan(0, 0, timeoutSeconds);
            var wait = new WebDriverWait(driver, ts);

            IWebElement repo = wait.Until((driver) => driver.FindElement(By.XPath("//*[@title='euler2D-kfvs-Fortran2003']")));
            repo.Click();

            System.Threading.Thread.Sleep(6000);
        }

        [TearDown]
        public void MyFinalize()
        {
            driver.Close();
        }

    }

    [TestClass]
    public class TruongSQA003 : TruongSQA001 
    {
        [Test]
        public void GgSearch()
        {
            driver.Url = "https://www.google.com";

            IWebElement searchComboBox = driver.FindElement(By.XPath("//*[@class='gLFyf gsfi']"));
            searchComboBox.Click();
            searchComboBox.SendKeys("C# tutorials");
            System.Threading.Thread.Sleep(1000);

            IWebElement searchButton = driver.FindElement(By.Name("btnK"));
            searchButton.Click();
            System.Threading.Thread.Sleep(3000);
        }
    }
}
