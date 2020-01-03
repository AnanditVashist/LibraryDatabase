using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;

namespace cicTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            var driver = new ChromeDriver("C:/Users/User1/Desktop")
            
            {
                Url = ("http://127.0.0.1:5500/views/checklist.html")
                
            };
            var submitButton = driver.FindElementByXPath("//*[@id='body']/div[1]/a[2]/input");
            submitButton.Click();
            System.Console.ReadLine();
            driver.Dispose();

        }
    }
}
