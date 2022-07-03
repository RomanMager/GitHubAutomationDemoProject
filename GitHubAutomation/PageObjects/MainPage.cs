using OpenQA.Selenium;

namespace GitHubAutomation.PageObjects;

public class MainPage : BasePage
{
    private readonly By _welcomeMessage = By.XPath(".//main//h1");

    public MainPage(IWebDriver webDriver) : base(webDriver)
    {
    }

    public string GetWelcomeMessageText()
    {
        return _webDriver.FindElement(_welcomeMessage).Text;
    }
}