using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using Classwork9_02._05._2018_.Locators;

namespace Classwork9_02._05._2018_.PageObjects
{
    /// <summary>
    /// Search result page locators.
    /// </summary>
    public class SearchResultPage
    {
        IWebDriver driver;
        
        public SearchResultPage (IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        /// <summary>
        /// Sort cars by price. From cheap to expensive.
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        public void SortCarsByPrice(IWebDriver driver, WebDriverWait wait, SearchResultPageLocators searchResultLocators)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(searchResultLocators.sortByPriceAscending)).Click();
        }
        /// <summary>
        /// Get price of cheapest BMW M5.
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        /// <returns>Price of cheapest BMW M5</returns>
        public string GetPriceCheapestBMW_M5(IWebDriver driver, WebDriverWait wait, SearchResultPageLocators searchResultPageLocators)
        {
            IWebElement cheapestBMW_M5_Price = wait.Until(ExpectedConditions.ElementToBeClickable(searchResultPageLocators.cheapestBMW_M5));
            return cheapestBMW_M5_Price.Text;
        }
    }
}
