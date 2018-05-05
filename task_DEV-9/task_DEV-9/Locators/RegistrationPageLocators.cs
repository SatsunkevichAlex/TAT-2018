using System;
using OpenQA.Selenium;

namespace task_DEV_9
{
    /// <summary>
    /// Registration page locators.
    /// </summary>
    public class RegistrationPageLocators
    {
        public By emailLocator = By.Id("index_email");
        public By passwordLocator = By.XPath("//input[@id = 'index_pass']");
        public By loginButtonLocator = By.XPath("//*[@id = 'index_login_button']");
        public By myProfileLocator = By.XPath("//li[@id = 'l_pr']");
    }
}
