namespace SeleniumExercise;

public class PositionPage(IWebDriver driver) : BasePage(driver)
{
    private IWebElement _jobTitle = null!;

    public string GetJobTitle()
    {
        _jobTitle = Helper.LocateElement(Locators.Xpath, "//h1");
        return _jobTitle.Text;
    }
}