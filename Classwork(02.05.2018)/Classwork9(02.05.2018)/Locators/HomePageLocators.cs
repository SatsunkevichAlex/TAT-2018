using System;
using OpenQA.Selenium;

namespace Classwork9_02._05._2018_.Locators
{
    /// <summary>
    /// Home page locators.
    /// </summary>
    public class HomePageLocators
    {
        public By brandSelecter = By.XPath("//select[@name = 'brand_id[]']");
        public By brandBMW = By.XPath("//option[text() = 'BMW']");
        public By modelSelecter = By.XPath("//select[@id = 'model_id']");
        public By modelBMW_M5 = By.XPath("//option[text() = 'M5']");
        public By submitSearchBMW_M5 = By.XPath("//button[@id = 'submit_presearch']");
    }
}
