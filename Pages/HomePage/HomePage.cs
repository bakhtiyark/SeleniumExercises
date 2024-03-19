namespace SeleniumExercise;

public class HomePage(IWebDriver driver) : BasePage(driver)
{
    private IWebElement _careersLink = null!;
    private IWebElement _magnifyingGlassIcon = null!;
    private IWebElement _searchFormName = null!;
    private IWebElement _submitButton = null!;

    public void OpenCareersPage()
    {
        _careersLink = Helper.LocateElement(Locators.Xpath, "//*[@id=\"wrapper\"]/div[2]/div[1]/header/div/div/nav/ul/li[5]/span[1]/a");
        _careersLink.Click();
    }

    public void ClickMagnifyingGlassIcon()
    {
        _magnifyingGlassIcon = Helper.LocateElement(Locators.CssSelector,"span[class=\"search-icon dark-iconheader-search__search-icon\"]");
        _magnifyingGlassIcon.Click();
    }

    public void FillSearchItem(string str)
    {
        _searchFormName = Helper.LocateElement(Locators.Id,"new_form_search");
        _searchFormName.SendKeys(str);
    }

    public void SubmitSearchForm()
    {
        _submitButton = Helper.LocateElement(Locators.CssSelector,"span[class=\"bth-text-layer\"]");
        _submitButton.Click();
    }

    public IEnumerable<IWebElement> GetSearchResult()
    {
        return Helper.LocateElements(Locators.CssSelector,"div[class=\"search-results__items\"]");
    }
}