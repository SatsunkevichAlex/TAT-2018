using System;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using task_DEV_10.PageObjects;
using System.Threading;
using task_DEV_10.PageObjectsLocators;

namespace task_DEV_10
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            string interestedBrand = "BMW";
            //string interestedBrand = args [0];
            //Console.WriteLine("Interested car brand" + interestedBrand);

            IWebDriver driver = new FirefoxDriver();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(11));

            HomePage homePage = new HomePage(driver);
            homePage.GotoHomePage(driver);

            HomePageLocators homePageLocators = new HomePageLocators();
            SearchResultPage searchResultPage = homePage.FindInterestBrand(driver, homePageLocators, wait, interestedBrand);
            SearchResultPageLocators searchResultPageLocators = new SearchResultPageLocators();
            IWebElement carsOnPage = searchResultPage.GetAllCarsOnPage(driver, wait, searchResultPageLocators);


            Thread.Sleep(5000);
            driver.Quit();
        }
    }
}
