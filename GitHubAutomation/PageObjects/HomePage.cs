using GitHubAutomation.Utils;
using OpenQA.Selenium;

namespace GitHubAutomation.PageObjects;

public class HomePage : BasePage
{
    private readonly By _loginButton = By.XPath("//header//a[contains(text(), 'Sign in')]");

    public HomePage(IWebDriver webDriver) : base(webDriver)
    {
    }

    public LoginPage ClickOnLoginButton()
    {
        WaitUtil.WaitUntilVisible(_webDriver, _loginButton)
            .Click();
        return new LoginPage(_webDriver);
    }
}