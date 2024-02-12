namespace SeleniumExercise;

public class PositionPage(IWebDriver driver): BasePage(driver)
{
    private IWebElement _jobTitle = null!;

    public string GetJobTitle()
    {
        _jobTitle = driver.FindElement(By.XPath("//h1"));
        return _jobTitle.Text;
    }
}