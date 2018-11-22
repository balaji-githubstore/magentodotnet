using DataDrivenFramework.DataAccessLayer;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace DataDrivenFramework
{
    class Program
    {
        public static String ParentDir=Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

        static void Main(string[] args)
        {
            Console.WriteLine(ParentDir);
            ////var data = fileRead.XmlToDic(propDir); 
            
            //IWebDriver driver = new ChromeDriver(@"D:\Mine\Company\Maveric\Driver");
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(90));
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            ////driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            //driver.Manage().Window.Maximize();
            ////Process.Start(@"D:\Mine\Company\ABC\Doc\chrome_login.exe");
            ////driver.Url = "https://www.engprod2-spectrumbusiness.net";
            //driver.Url = "file:///D:/Mine/PythonCode/All%20Code/HTML-CSS/DEMO1.html";
            //driver.FindElement(By.Id("fileToUpload")).Click();
            //// string configUrl = ConfigurationManager.AppSettings["url"];
            //var process=Process.Start(@"D:\Mine\Company\ABC\Doc\Uploadautoit.exe");
            //process.WaitForExit();
            //String xmlDir = ParentDir + @"\Test Data\magentodata.xml";
            //String propDir = ParentDir + @"\Test Data\data.properties";

            //FileReader fileRead = new FileReader();

            //var data = fileRead.XmlToDic(propDir); 
            //var data = fileRead.XmlToDic(xmlDir);
            //IWebDriver driver = new ChromeDriver(@"D:\Mine\Company\Maveric\Driver");
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(90));
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            ////driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            //driver.Manage().Window.Maximize();
           // driver.Url = data["url"]; //wait for infinite time


            //IWebElement myAccountEle = driver.FindElement(By.LinkText("My Account"));
            //myAccountEle.Click();

            //// Thread.Sleep(10000);

            //LoginPage login = new LoginPage(driver);

            //login.EnterEmailAddress(data["username"]);


            //IWebElement emailEle = driver.FindElement(By.Id("email"));
            //emailEle.SendKeys(data["username"]);

            //IWebElement passEle = driver.FindElement(By.Name("login[password]"));
            //passEle.SendKeys(data["password"]);

            //passEle.Submit();

            //IWebElement loginEle = driver.FindElement(By.Id("send2"));
            //loginEle.Click();


            ////wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(driver.FindElements(By.PartialLinkText("Out"))));
            //wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.PartialLinkText("Out")));

            //String actualTitle = driver.Title;

            //if (actualTitle.Equals(data["expectedTitle"]))
            //{
            //    Console.WriteLine("Test passed");
            //}
            //else
            //{
            //    Console.WriteLine("Failed");
            //}

            //IWebElement logOut = driver.FindElement(By.PartialLinkText("Out"));
            //logOut.Click();




            //String currentDir = Directory.GetCurrentDirectory();
            //Console.WriteLine(currentDir);
            //String xmldir = Directory.GetParent(currentDir).Parent.FullName;

















            // String filePath = @"D:\Mine\Company\Mphasis\DataDrivenFramework\DataDrivenFramework\Test Data\data.properties";





            //@"D:\Mine\Company\Mphasis\DataDrivenFramework\DataDrivenFramework\Test Data\data.properties"

            //Console.WriteLine(data["url"]);





        }
    }
}
