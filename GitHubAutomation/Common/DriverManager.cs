using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Safari;
using static GitHubAutomation.Common.BrowserName;

namespace GitHubAutomation.Common;

public static class DriverManager
{
    private static IWebDriver _webDriver;
    
    public static void CreateDriver(BrowserName browser)
    {
        switch (browser)
        {
            case Chrome:
                _webDriver = new ChromeDriver();
                break;
            case FireFox:
                _webDriver = new FirefoxDriver();
                break;
            case Safari:
                _webDriver = new SafariDriver();
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(browser), browser, null);
        }
    }

    public static IWebDriver GetDriver()
    {
        return _webDriver;
    }
}

public enum BrowserName
{
    Chrome,
    FireFox,
    Safari
}