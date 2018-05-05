using System;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using task_DEV_9.PageObjects;
using task_DEV_9.Locators;

namespace task_DEV_9
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            IWebDriver driver = new FirefoxDriver();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(11));

            RegistrationPageLocators registrationPageLocators = new RegistrationPageLocators();
            RegistrationPage registrationPage = new RegistrationPage(driver);
            registrationPage.GoToRegistrationPage(driver);
            HomePage homePage = registrationPage.RegistrationUserSuccesful(user, wait, registrationPageLocators);

            HomePageLocators homePageLocators = new HomePageLocators();
            MessagesPage messagesPage = homePage.GoToMessagesPage(driver, homePageLocators, wait);

            MessagesPageLocators messagesPageLocators = new MessagesPageLocators();
            LastDialogPage lastDialogPage = messagesPage.GoToLastDialog(driver, messagesPageLocators, wait);

            LastDialogLocators lastDialogLocators = new LastDialogLocators();
            Console.WriteLine("Last mesage : " + lastDialogPage.GetTextOfLastMessage(driver, lastDialogLocators, wait));

            Thread.Sleep(4000);
            driver.Quit();
        }
    }
}
