using System;
using OpenQA.Selenium;

namespace task_DEV_9
{
    public class Locators
    {
        public By emailLocator = By.Id("index_email");
        public By passwordLocator = By.XPath("//input[@id = 'index_pass']");
        public By loginButtonLocator = By.XPath("//*[@id = 'index_login_button']");
        public By massagesLocator = By.XPath("//li[@id = 'l_msg']");
        public By firstDialogLocator = By.XPath("//*[@id='im_dialogs']/li[1]");
        public By lastMassageLocator = By.XPath("//*[@class = '_im_peer_history im-page-chat-contain']/div[last()]");
        public By userNicknameLocator = By.XPath("//h2[@class = 'page_name']");
        public By myProfileLocator = By.XPath("//li[@id = 'l_pr']");
    }
}
