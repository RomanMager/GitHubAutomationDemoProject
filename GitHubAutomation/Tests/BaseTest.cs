using GitHubAutomation.Common;
using GitHubAutomation.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;

namespace GitHubAutomation.Tests;

public class BaseTest
{
    private IWebDriver? _webDriver;

    protected HomePage HomePage;
    protected LoginPage LoginPage;
    protected MainPage MainPage;

    [SetUp]
    public void SetUp()
    {
        DriverManager.CreateDriver(BrowserName.Chrome);
        _webDriver = DriverManager.GetDriver();
        _webDriver.Manage().Window.Maximize();
        _webDriver.Url = "https://github.com";

        HomePage = new HomePage(_webDriver);
        LoginPage = new LoginPage(_webDriver);
        MainPage = new MainPage(_webDriver);
    }

    [TearDown]
    public void TearDown()
    {
        _webDriver?.Quit();
    }
}