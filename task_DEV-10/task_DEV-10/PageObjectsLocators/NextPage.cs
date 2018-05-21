using System;
using OpenQA.Selenium;

namespace task_DEV_10.PageObjectsLocators
{
    /// <summary>
    /// Next page of search.
    /// </summary>
    public class NextPage
    {
        IWebDriver driver;
        public NextPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
