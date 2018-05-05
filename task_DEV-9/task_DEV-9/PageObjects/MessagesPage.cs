using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using task_DEV_9.Locators;
using System.Threading;

namespace task_DEV_9.PageObjects
{
    public class MessagesPage
    {
        IWebDriver driver;
        public MessagesPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }
        /// <summary>
        /// Go to last dialog page.
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="messagesPageLocators"></param>
        /// <param name="wait"></param>
        /// <returns>LastDialogPage</returns>
        public LastDialogPage GoToLastDialog(IWebDriver driver, MessagesPageLocators messagesPageLocators, WebDriverWait wait)
        {
            IWebElement lastDialog = wait.Until(ExpectedConditions.ElementToBeClickable(messagesPageLocators.lastDialogLocator));
            Thread.Sleep(1000); //Need this line because .Click() don't work. It just select last dialog without Sleep().
            lastDialog.Click();
            return new LastDialogPage(driver);
        }
    }
}
