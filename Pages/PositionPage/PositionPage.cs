namespace SeleniumExercise;

public class PositionPage(IWebDriver driver) : BasePage(driver)
{
    private IWebElement _jobTitle = null!;
    private readonly IWebDriver _driver = driver;

    public string GetJobTitle()
    {
        _jobTitle = _driver.FindElement(By.XPath("//h1"));
        return _jobTitle.Text;
    }
}