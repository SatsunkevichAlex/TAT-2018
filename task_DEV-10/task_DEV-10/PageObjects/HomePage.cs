using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using task_DEV_10.PageObjectsLocators;

namespace task_DEV_10.PageObjects
{
    /// <summary>
    /// Home page.
    /// </summary>
    class HomePage
    {
        IWebDriver driver;
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        /// <summary>
        /// Go to home page.
        /// </summary>
        /// <param name="driver"></param>
        public void GotoHomePage(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://av.by");
        }

        /// <summary>
        /// Search cars of interested brand.
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="homePageLocators"></param>
        /// <param name="wait"></param>
        /// <param name="interestedBrand"></param>
        /// <returns>SearchResultPage.</returns>
        public SearchResultPage FindInterestBrand(IWebDriver driver, HomePageLocators homePageLocators, WebDriverWait wait, string selectedBrand)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(homePageLocators.brandSearchFilterParameter)).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(String.Format("//select[@name = 'brand_id[]']/option[text() = '{0}']", selectedBrand)))).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(homePageLocators.searchButton)).Click();
            return new SearchResultPage(driver);
        }
    }
}
