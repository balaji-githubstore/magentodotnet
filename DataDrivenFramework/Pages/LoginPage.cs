//using OpenQA.Selenium;
//using OpenQA.Selenium.Support.PageObjects;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataDrivenFramework.Pages
//{
//    class LoginPage
//    {
//        [FindsBy(How = How.Id, Using = "email")]
//        IWebElement emailElement;

//        [FindsBy(How = How.XPath, Using = "//input[@name='login[password]']")]
//        IWebElement passwordElement;

//        [FindsBy(How = How.Id, Using = "send")]
//        IWebElement loginElement;


//        IWebDriver driver;
//        public LoginPage(IWebDriver driver)
//        {
//            this.driver = driver;
//            PageFactory.InitElements(driver, this);
//        }


//        public void EnterEmailAddress(String userName)
//        {
//            //IWebElement emailElement = driver.FindElement(email);
//            emailElement.SendKeys(userName);
//        }

//        public void EnterPassword(String password, IWebDriver driver)
//        {
//            //IWebElement passwordElement = driver.FindElement(pass);
//            passwordElement.SendKeys(password);
//        }

//        public void ClickOnLogin(IWebDriver driver)
//        {
//            //   IWebElement loginElement = driver.FindElement(login);
//            loginElement.Click();
//        }
//    }
//}
