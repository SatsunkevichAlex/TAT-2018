using System;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using task_DEV_10.PageObjects;
using task_DEV_10.PageObjectsLocators;

namespace task_DEV_10
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                string selectedBrand = args[0];

                IWebDriver driver = new FirefoxDriver();
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(11));

                Console.WriteLine("Selected car brand: " + selectedBrand);
                HomePageLocators homePageLocators = new HomePageLocators();
                HomePage homePage = new HomePage(driver);
                homePage.GotoHomePage(driver);

                SearchResultPage searchResultPage = homePage.FindInterestBrand(driver, homePageLocators, wait, selectedBrand);
                SearchResultPageLocators searchResultPageLocators = new SearchResultPageLocators();
                searchResultPage.OutputSortedCars(searchResultPage.SortedCarsList(searchResultPage.GetCarsAllPages(driver, searchResultPageLocators, wait)));

                driver.Quit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
