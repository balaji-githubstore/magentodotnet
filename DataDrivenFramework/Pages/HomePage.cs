//using OpenQA.Selenium;
//using OpenQA.Selenium.Support.PageObjects;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataDrivenFramework.Pages
//{
//    class HomePage : HomePageields
//    {
//        //By myAccount = By.LinkText("MY ACCOUNT");
//        IWebDriver driver;

//        [FindsBy(How = How.LinkText, Using = myAccountLoc)]
//        private IWebElement myAccount;

//        [FindsBy(How = How.TagName, Using = "a")]
//        private IList<IWebElement> links;

//        public HomePage(IWebDriver driver)
//        {
//            this.driver = driver;
//            PageFactory.InitElements(driver, this);
//        }

//        public void ClickOnMyAccount()
//        {
//            myAccount.Click();

//            foreach (IWebElement e in links)
//            {
//                Console.WriteLine(e.Text);
//            }
//        }
//    }

//}
