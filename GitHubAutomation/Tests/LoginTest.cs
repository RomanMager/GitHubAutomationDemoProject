using NUnit.Framework;

namespace GitHubAutomation.Tests;

public class LoginTest : BaseTest
{
    private const string Email = "";
    private const string Password = "";

    [Test]
    public void UserCanLogIn_WithValidCredentials()
    {
        HomePage.ClickOnLoginButton();
        LoginPage.LogInWithValidCredentials(Email, Password);
        Assert.AreEqual(MainPage.GetWelcomeMessageText(), "The home for all developers — including you.");
    }
}