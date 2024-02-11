namespace SeleniumExercise;

public class CareersPage(IWebDriver driver) : BasePage(driver)
{
    private IWebElement _keywordField = null!;
    private IWebElement _remoteCheckbox = null!;
    private IWebElement _submitButton = null!;
    private readonly IWebDriver _driver = driver;

    public void SearchPosition(TestData data)
    {
        FillLanguageField(data);
        SelectLocation();
        SetRemoteCheckbox(data);
        SubmitSearchForm();
    }

    private void SubmitSearchForm()
    {
        _submitButton = _driver.FindElement(By.CssSelector("button[type='submit']"));
        _submitButton.Click();
    }

    private void FillLanguageField(TestData data)
    {
        _keywordField = _driver.FindElement(By.Id("new_form_job_search-keyword"));
        _keywordField.SendKeys(data.DesiredLanguage);
    }

    private void SetRemoteCheckbox(TestData data)
    {
        _remoteCheckbox =
            _driver.FindElement(By.XPath("//label[@for=\"id-93414a92-598f-316d-b965-9eb0dfefa42d-remote\"]"));
        if (data.Remote)
        {
            _remoteCheckbox.Click();
        }
    }

    private void SelectLocation()
    {
        IWebElement locationDropdown = _driver.FindElement(By.CssSelector("div[class=\"recruiting-search__location\"]"));
        locationDropdown.Click();
        IWebElement locationElement = _driver.FindElement(By.XPath("//li[@title=\"All Locations\"]"));
        locationElement.Click();
    }
}