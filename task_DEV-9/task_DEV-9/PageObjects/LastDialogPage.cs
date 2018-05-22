using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects; 
using task_DEV_9.Locators;

namespace task_DEV_9.PageObjects
{
    /// <summary>
    /// Last dialog page.
    /// </summary>
    public class LastDialogPage
    {
        IWebDriver driver;
        public LastDialogPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }
        /// <summary>
        /// Get text of last message.
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="lastDialogLocators"></param>
        /// <param name="wait"></param>
        /// <returns>Text of last message.</returns>
        public string GetTextOfLastMessage(IWebDriver driver, LastDialogLocators lastDialogLocators, WebDriverWait wait)
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(lastDialogLocators.lastMassageLocator)).Text;
        }
    }
}
