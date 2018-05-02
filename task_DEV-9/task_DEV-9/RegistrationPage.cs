using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;

namespace task_DEV_9
{
    /// <summary>
    /// Registration page 
    /// </summary>
    public class RegistrationPage
    {
        IWebDriver driver;
        public RegistrationPage(IWebDriver driver)
        {
            if(driver.Url != "https://vk.com/")
            {
                throw new Exception("This is not registration page");
            }
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }
        
        /// <summary>
        /// Register user
        /// </summary>
        /// <param name="user"></param>
        public void RegisterUser(User user, WebDriverWait wait, Locators locators)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(locators.emailLocator)).SendKeys(user.Email);
            wait.Until(ExpectedConditions.ElementToBeClickable(locators.passwordLocator)).SendKeys(user.Password);
            wait.Until(ExpectedConditions.ElementToBeClickable(locators.loginButtonLocator)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(locators.myProfileLocator)).Click();
        }
        /// <summary>
        /// Seccesfull registration
        /// </summary>
        /// <param name="user"></param>
        /// <param name="wait"></param>
        /// <param name="locators"></param>
        /// <returns>Homepage</returns>
        public HomePage RegistrationUserSuccesful(User user, WebDriverWait wait, Locators locators)
        {
            RegisterUser(user, wait, locators);
            return new HomePage(driver, locators, wait);
        }
        /// <summary>
        /// Unseccesfull registration
        /// </summary>
        /// <param name="user"></param>
        /// <param name="wait"></param>
        /// <param name="locators"></param>
        /// <returns>Registration page</returns>
        public RegistrationPage RegistrationUserUnsuccessful(User user, WebDriverWait wait, Locators locators)
        {
            RegisterUser(user, wait, locators);
            return new RegistrationPage(driver);
        }
    }
}
