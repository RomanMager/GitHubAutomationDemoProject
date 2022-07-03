using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace GitHubAutomation.Utils;

public static class WaitUtil
{
    public static IWebElement WaitUntilVisible(IWebDriver webDriver, By elementSelector)
    {
        WebDriverWait wait = new WebDriverWait(webDriver, timeout: TimeSpan.FromSeconds(30))
        {
            PollingInterval = TimeSpan.FromSeconds(5)
        };

        wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));

        return wait.Until(driver => driver.FindElement(elementSelector));
    }
}