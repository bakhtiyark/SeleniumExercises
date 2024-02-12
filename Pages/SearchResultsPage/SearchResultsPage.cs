namespace SeleniumExercise;

public class SearchResultsPage(IWebDriver driver) : BasePage(driver)
{
    private IWebElement _lastItem = null!;
    private IWebElement _lastItemLink = null!;
    private readonly IWebDriver _driver = driver;

    public void SelectLastElement()
    {
        _lastItem = _driver.FindElement(By.CssSelector("li[class=\"search-result__item\"]:last-child"));
        _lastItemLink = _lastItem.FindElement(By.XPath("//a[contains(text(), \"View and apply\")]"));
        _lastItemLink.Click();
    }
}