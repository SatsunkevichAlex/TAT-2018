using System;
using OpenQA.Selenium;

namespace task_DEV_9.Locators
{
    /// <summary>
    /// Messages page locators.
    /// </summary>
    public class MessagesPageLocators
    {
        public By lastDialogLocator = By.XPath("//*[@id='im_dialogs']/li[1]");
    }
}
