using System;
using OpenQA.Selenium;

namespace task_DEV_9.Locators
{
    /// <summary>
    /// Last dialog page locators.
    /// </summary>
    public class LastDialogLocators
    {
        public By lastMassageLocator = By.XPath("//*[@class = '_im_peer_history im-page-chat-contain']/div[last()]");
    }
}
