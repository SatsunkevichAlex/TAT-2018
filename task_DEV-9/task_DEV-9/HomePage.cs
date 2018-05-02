using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace task_DEV_9
{
    public class HomePage
    {
        public IWebElement userName;
        public HomePage (IWebDriver driver, Locators locators, WebDriverWait wait)
        {
            wait.Until(ExpectedConditions.ElementExists(locators.userNicknameLocator));
            userName = driver.FindElement(locators.userNicknameLocator);
        }
    }
}
