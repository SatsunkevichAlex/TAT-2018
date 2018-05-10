using System;
using OpenQA.Selenium;

namespace task_DEV_10.PageObjectsLocators
{
    /// <summary>
    /// Search result page locators.
    /// </summary>
    public class SearchResultPageLocators
    {
        public By carsOnPage = By.XPath("//div[@class = 'listing-wrap']");
        public By brandAndModelOfCars = By.XPath("//div[@class = 'listing-item-title']//h4/*[@href]");
    }
}
