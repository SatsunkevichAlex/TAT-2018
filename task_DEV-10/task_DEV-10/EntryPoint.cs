using System;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using task_DEV_10.PageObjects;
using task_DEV_10.PageObjectsLocators;
using System.Collections.Generic;

namespace task_DEV_10
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                //string interestedBrand = args[0];
                string selectedBrand = "Acura";
                Console.WriteLine("Selected car brand " + selectedBrand);

                IWebDriver driver = new FirefoxDriver();
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(11));

                HomePage homePage = new HomePage(driver);
                homePage.GotoHomePage(driver);

                HomePageLocators homePageLocators = new HomePageLocators();
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
