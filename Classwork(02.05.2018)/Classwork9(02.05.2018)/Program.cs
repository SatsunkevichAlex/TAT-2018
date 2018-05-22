using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using Classwork9_02._05._2018_.PageObjects;
using Classwork9_02._05._2018_.Locators;


namespace Classwork9_02._05._2018_
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            HomePage homePage = new HomePage(driver);
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 11));

            HomePageLocators homePageLocators = new HomePageLocators();
            homePage.GoToHomePage();
            homePage.InputFilterParametersForBMW_M5(driver, wait, homePageLocators);
            SearchResultPage searchResultPage = homePage.GoToSearchResultPage(driver, wait, homePageLocators);

            SearchResultPageLocators searchResultPageLocators = new SearchResultPageLocators();
            searchResultPage.SortCarsByPrice(driver, wait, searchResultPageLocators);
            Console.WriteLine("Price of cheapest BMW M5 : " + searchResultPage.GetPriceCheapestBMW_M5(driver, wait, searchResultPageLocators));

            driver.Quit();
        }
    }
}
