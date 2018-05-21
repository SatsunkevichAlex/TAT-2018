using System;
using OpenQA.Selenium;

namespace task_DEV_10.PageObjectsLocators
{
    /// <summary>
    /// Home page licators.
    /// </summary>
    public class HomePageLocators
    {
        public By brandSearchFilterParameter = By.XPath("//select[@name = 'brand_id[]']");
        public By allBrandsFilterParameter = By.XPath("//select[@name = 'brand_id[]']/option");
        public By searchButton = By.XPath("//button[@type = 'submit']");
    }
}
