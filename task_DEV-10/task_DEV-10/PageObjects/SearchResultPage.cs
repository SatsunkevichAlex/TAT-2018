using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using task_DEV_10.PageObjectsLocators;
using System.Collections.Generic;

namespace task_DEV_10.PageObjects
{
    /// <summary>
    /// Search result page.
    /// </summary>
    public class SearchResultPage
    {
        IWebDriver driver;
        public SearchResultPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        /// <summary>
        /// Get brand and model of cars on page.
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        /// <param name="searchResultPageLocators"></param>
        /// <returns>List of brands and models of cars on page.</returns>
        public IList<IWebElement> GetBrandAndModelOfCarsOnPage(IWebDriver driver, WebDriverWait wait, SearchResultPageLocators searchResultPageLocators)
        {
            return driver.FindElements(searchResultPageLocators.brandAndModelOfCars);
        }
    }
}
