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
            //Arrange
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https://vk.com");
            RegistrationPage registrationPage = new RegistrationPage(driver);
            Locators locators = new Locators();
            User user = new User();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(11));

            //Act
            driver.Manage().Window.Maximize();
            HomePage resultPage = registrationPage.RegistrationUserSuccesful(user, wait, locators);

            //Assert
            HomePage homePage = new HomePage(driver, locators, wait);
            Assert.AreEqual(resultPage.userName.Text, homePage.userName.Text);
            driver.Quit();
        }
    }
}
