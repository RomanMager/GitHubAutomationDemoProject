using OpenQA.Selenium;

namespace GitHubAutomation.PageObjects;

public abstract class BasePage
{
    protected IWebDriver _webDriver;

    protected BasePage(IWebDriver webDriver)
    {
        _webDriver = webDriver;
    }
}