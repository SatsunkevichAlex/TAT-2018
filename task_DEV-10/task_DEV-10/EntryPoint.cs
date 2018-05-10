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
            IList<IWebElement> brandAndModelOfCarsOnPage = searchResultPage.GetBrandAndModelOfCarsOnPage(driver, wait, searchResultPageLocators);
            foreach (IWebElement carBrandAndModel in brandAndModelOfCarsOnPage)
            {
                Console.WriteLine(carBrandAndModel.Text);
            }

            driver.Quit();
        }
    }
}
