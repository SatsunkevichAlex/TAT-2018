using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using task_DEV_9.PageObjects;

namespace task_DEV_9
{
    /// <summary>
    /// Homepage.
    /// </summary>
    public class HomePage
    {
        IWebDriver driver;
        public HomePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }
        /// <summary>
        /// Go to messages page.
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="homePageLocators"></param>
        /// <param name="wait"></param>
        /// <returns>MessagePage</returns>
        public MessagesPage GoToMessagesPage(IWebDriver driver, HomePageLocators homePageLocators, WebDriverWait wait)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(homePageLocators.massagesLocator)).Click();
            return new MessagesPage(driver);
        }
    }
}
