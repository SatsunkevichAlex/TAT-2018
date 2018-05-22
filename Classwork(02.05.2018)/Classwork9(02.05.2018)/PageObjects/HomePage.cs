using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using Classwork9_02._05._2018_.Locators;

namespace Classwork9_02._05._2018_.PageObjects
{
    /// <summary>
    /// Homepage.
    /// </summary>
    public class HomePage
    {
        IWebDriver driver;
        public HomePage (IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        /// <summary>
        /// Input filter parameters.
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        public void InputFilterParametersForBMW_M5(IWebDriver driver, WebDriverWait wait, HomePageLocators homePageLocators)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(homePageLocators.brandSelecter)).Click(); ;
            wait.Until(ExpectedConditions.ElementToBeClickable(homePageLocators.brandBMW)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(homePageLocators.modelSelecter)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(homePageLocators.modelBMW_M5)).Click();
        }
        /// <summary>
        /// Go to search result page.
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        /// <returns>Search result page.</returns>
        public SearchResultPage GoToSearchResultPage(IWebDriver driver, WebDriverWait wait, HomePageLocators homePageLocators)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(homePageLocators.submitSearchBMW_M5)).Click();
            return new SearchResultPage(driver);
        }
        /// <summary>
        /// Go to home page.
        /// </summary>
        public void GoToHomePage()
        {
            driver.Navigate().GoToUrl("https://av.by");
            driver.Manage().Window.Maximize();
        }
    }
}
