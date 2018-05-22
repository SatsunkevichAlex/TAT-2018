using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;

namespace task_DEV_9.UnitTests
{
    [TestFixture]
    class RegistrationPageTests
    {
        [Test]
        public void RegistrationUserSuccesful_CorrectRegistration_ReturnTrue()
        {
            IWebDriver driver = new FirefoxDriver();
            RegistrationPage registrationPage = new RegistrationPage(driver);
            RegistrationPageLocators registrationPageLocators = new RegistrationPageLocators();
            HomePageLocators homePageLocators = new HomePageLocators();
            User user = new User();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(11));

            registrationPage.GoToRegistrationPage(driver);
            HomePage resultPage = registrationPage.RegistrationUserSuccesful(user, wait, registrationPageLocators);
            driver.Quit();
        }
    }
}
