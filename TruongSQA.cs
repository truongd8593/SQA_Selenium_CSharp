using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace SeleniumHello
{
    [TestClass]
    public class OpenChromeURL
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
            driver.Manage().Window.Maximize();
            driver.Url = "http://forums.silverfrost.com";
        }

        [TearDown]
        public void MyFinalize()
        {
            driver.Close();
        }
    }

    [TestClass]
    public class OpenGitHubRepo
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
            driver.Manage().Window.Maximize();
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
    public class GoogleSearch 
    {
        public IWebDriver driver;

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void GgSearch()
        {
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.google.com";

            IWebElement searchComboBox = driver.FindElement(By.XPath("//*[@class='gLFyf gsfi']"));
            searchComboBox.Click();
            searchComboBox.SendKeys("C# tutorials");
            System.Threading.Thread.Sleep(1000);

            IWebElement searchButton = driver.FindElement(By.Name("btnK"));
            searchButton.Click();
            System.Threading.Thread.Sleep(3000);
        }

        [TearDown]
        public void MyFinalize()
        {
            driver.Close();
        }
    }

    [TestClass]
    public class RegisterAccountGuru99
    {
        public IWebDriver driver;

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void RegisterAccount()
        {
            driver.Url = "http://demo.guru99.com/test/newtours/index.php";

            // Verify web title
            string title = driver.Title;
            if (title != "Welcome: Mercury Tours")
            {
                MyFinalize();
            }

            // Click Register
            IWebElement registerBtn = driver.FindElement(By.LinkText("REGISTER"));
            registerBtn.Click();

            // Verify new web title
            title = driver.Title;
            if (title != "Register: Mercury Tours")
            {
                MyFinalize();
            }

            //Fill in personal information
            IWebElement firstName = driver.FindElement(By.Name("firstName"));
            firstName.SendKeys("Truong");
            IWebElement lastName = driver.FindElement(By.Name("lastName"));
            lastName.SendKeys("Dang");
            IWebElement phone = driver.FindElement(By.Name("phone"));
            phone.SendKeys("012345678");
            IWebElement userName = driver.FindElement(By.Id("userName"));
            userName.SendKeys("dangtruong@gmail.com");
            IWebElement adddress1 = driver.FindElement(By.Name("address1"));
            adddress1.SendKeys("123 Unkown Street Ward 1");
            IWebElement city = driver.FindElement(By.Name("city"));
            city.SendKeys("Asgard");
            IWebElement state = driver.FindElement(By.Name("state"));
            state.SendKeys("Asgard");
            IWebElement postalCode = driver.FindElement(By.Name("postalCode"));
            postalCode.SendKeys("99999");
            IWebElement country = driver.FindElement(By.Name("country"));
            country.SendKeys("VIET NAM");

            IWebElement email = driver.FindElement(By.Name("email"));
            email.SendKeys("Truong");
            IWebElement password = driver.FindElement(By.Name("password"));
            password.SendKeys("123456");
            password = driver.FindElement(By.Name("confirmPassword"));
            password.SendKeys("123456");

            IWebElement submitBtn = driver.FindElement(By.Name("submit"));
            submitBtn.Click();
        }

        [TearDown]
        public void MyFinalize()
        {
            driver.Close();
        }
    }
}
