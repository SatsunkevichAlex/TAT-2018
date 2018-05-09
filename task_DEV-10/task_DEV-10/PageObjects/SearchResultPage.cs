using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using task_DEV_10.PageObjectsLocators;

namespace task_DEV_10.PageObjects
{
    public class SearchResultPage
    {
        IWebDriver driver;
        public SearchResultPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }
        /// <summary>
        /// Get all cars on page.
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        /// <param name="searchResultPageLocators"></param>
        /// <returns>All cars on page.</returns>
        public IWebElement GetAllCarsOnPage(IWebDriver driver, WebDriverWait wait, SearchResultPageLocators searchResultPageLocators)
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(searchResultPageLocators.carsOnPage));
        }
    }
}
