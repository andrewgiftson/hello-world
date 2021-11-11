using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace AutomationWinappDriver
{
    [TestClass]
    public class UnitTest1
    {
        //Appium Driver URL it works like a windows Service on your PC  

        private const string appiumDriverURI = "http://127.0.0.1:4723";
   
        private const string calApp = "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App";

        protected static WindowsDriver<WindowsElement> Window;

        [TestMethod]
        public void TestMethod1()
        {
           

            if (Window == null)

            {
                IWebDriver Driver;
                //Driver = new FirefoxDriver();
                //Driver = new ChromeDriver();

                Driver = new InternetExplorerDriver();

                //implicit wait
                Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                //Appiumptions
                AppiumOptions desiredcapabilities = new AppiumOptions();
                desiredcapabilities.AddAdditionalCapability("app", "Root");
                desiredcapabilities.AddAdditionalCapability("deviceName", "WindowsPC");
                //Create a session to intract with Calculator windows application  
                Window = new WindowsDriver<WindowsElement>(new Uri(appiumDriverURI), desiredcapabilities);

                //File upload
                //Driver.Navigate().GoToUrl("http://demo.automationtesting.in/Register.html");
                //var chooseFileButton = Driver.FindElement(By.XPath("//input[@id='imagesrc']"));
                //new Actions(Driver).Click(chooseFileButton).Perform();
                //IWebElement openWindowPopupFileNameTextbox = Window.FindElementByXPath("//Edit[@Name='File name:']");
                //openWindowPopupFileNameTextbox.SendKeys("D:\\Data.txt");
                ////IWebElement openWindowPopupOpenButton = Window.FindElementByXPath("//Button[@Name='Open'][@AutomationId='1']");
                //IWebElement openWindowPopupOpenButton = Window.FindElementByName("Open");
                //openWindowPopupOpenButton.Click();


                //Download button
                Driver.Navigate().GoToUrl("https://www.qafeast.com/demo");
                IJavaScriptExecutor js = Driver as IJavaScriptExecutor;
                js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
                Driver.FindElement(By.XPath("//label[text()='File Upload & Download event']")).Click();
                IWebElement CSV =  Driver.FindElement(By.XPath("//a[text()='Regression.csv']"));
                new Actions(Driver).Click(CSV).Perform();
                Window.FindElementByXPath("//Button[@Name='Save']").Click();
                Window.FindElementByName("Open").Click();
                try
                {
                    Window.FindElementByXPath("//Button[@Name='Allow']").Click();
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                }
                Driver.Quit();

                //                
                //WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
                //wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@id='imagesrc']")));
                //                
                //AppiumOptions desiredcapabilities = new AppiumOptions();
                //desiredcapabilities.AddAdditionalCapability("app","Root");
                //desiredcapabilities.AddAdditionalCapability("deviceName", "WindowsPC");
                ////Create a session to intract with Calculator windows application  
                //Window = new WindowsDriver<WindowsElement>(new Uri(appiumDriverURI), desiredcapabilities);
                // uploading a sample file called “Data.txt” from the D drive.
                ////WebDriverWait w = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
                ////w.Until(ExpectedConditions.ElementExists(By.XPath("//strong[text()='Free Download']")));
                //Driver.FindElement(By.XPath("//strong[text()='Free Download']")).Click();
                //Window.FindElement(By.Name("Save")).Click();
                ////Window.FindElement(By.Name("Issuer: KynetixDevCertAuth")).Click();
                ////Window.FindElement(By.Name("OK")).Click();

                ////Automate Button and Get answer from Calculator  

                ////find by Name  
                //calSession.FindElement(By.Name("Nine")).Click();
                //calSession.FindElement(By.Name("One")).Click();
                //calSession.FindElement(By.Name("Two")).Click();
                //calSession.FindElement(By.Name("Three")).Click();
                //calSession.FindElement(By.Name("Multiply by")).Click();
                ////find by automation id  
                //calSession.FindElementByAccessibilityId("num9Button").Click();
                //calSession.FindElementByAccessibilityId("equalButton").Click();
                ////getting value from textbox  
                //string ExpectedValue = calSession.FindElementByAccessibilityId("CalculatorResults").Text;
                //string ExpectedValue1 = ExpectedValue.Replace("Display is ", "").Replace(",", "");

                ////Testcases  
                //Assert.AreEqual(82107, Convert.ToInt64(ExpectedValue1));
                //calSession.Quit();
            }
        }

    }

}