using NUnit.Framework;

namespace GitHubAutomation.Tests;

public class LoginTest : BaseTest
{
    [Test]
    public void UserCanLogIn_WithValidCredentials()
    {
        HomePage.ClickOnLoginButton();
        string email = "secex50043@shbiso.com";
        string password = "Inno@10021998";
        LoginPage.LogInWithValidCredentials(email, password);
        Assert.AreEqual(MainPage.GetWelcomeMessageText(), "The home for all developers — including you.");
    }
}