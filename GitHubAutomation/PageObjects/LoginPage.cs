using GitHubAutomation.Utils;
using OpenQA.Selenium;

namespace GitHubAutomation.PageObjects;

public class LoginPage : BasePage
{
    private By _emailInput = By.Id("login_field");
    private By _passwordInput = By.Id("password");
    private By _signInButton = By.XPath("//input[contains(@value, 'Sign in')]");

    public LoginPage(IWebDriver webDriver) : base(webDriver)
    {
    }

    public LoginPage EnterEmail(string email)
    {
        WaitUtil.WaitUntilVisible(_webDriver, _emailInput)
            .SendKeys(email);
        return this;
    }

    public LoginPage EnterPassword(string password)
    {
        WaitUtil.WaitUntilVisible(_webDriver, _passwordInput)
            .SendKeys(password);
        return this;
    }

    public LoginPage ClickSignInButton()
    {
        WaitUtil.WaitUntilVisible(_webDriver, _signInButton)
            .Click();
        return this;
    }

    public LoginPage LogInWithValidCredentials(string email, string password)
    {
        return EnterEmail(email)
            .EnterPassword(password)
            .ClickSignInButton();
    }

    public LoginPage LogInWithInvalidCredentials(string email, string password)
    {
        throw new NotImplementedException();
    }
}