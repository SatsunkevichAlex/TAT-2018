using System;
using OpenQA.Selenium;

namespace Classwork9_02._05._2018_.Locators
{
    /// <summary>
    /// Search result page locators.
    /// </summary>
    public class SearchResultPageLocators
    {
        public By sortByPriceAscending = By.XPath("//li[a[2]]");
        public By cheapestBMW_M5 = By.XPath("//div[@class = 'listing-item-price'][1]//strong");
    }
}
