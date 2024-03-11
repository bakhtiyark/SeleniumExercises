using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SeleniumExercise;

public class HomePage(IWebDriver driver) : BasePage(driver)
{
    
    private readonly IWebDriver _driver = driver;
    private IWebElement _careersLink = null!;
    private IWebElement _magnyingGlassIcon = null!;
    private IWebElement _searchFormName = null!;
    private IWebElement _submitButton = null!;
    public void OpenCareersPage()
    {
        _careersLink = _driver.FindElement(By.XPath("//*[@id=\"wrapper\"]/div[2]/div[1]/header/div/div/nav/ul/li[5]/span[1]/a")); 
        _careersLink.Click();
    }

    public void ClickMagnifyingGlassIcon()
    {
        _magnyingGlassIcon =
            _driver.FindElement(By.CssSelector("span[class=\"search-icon dark-iconheader-search__search-icon\"]"));
        _magnyingGlassIcon.Click();
    }

    public void FillSearchItem(string str)
    {
        _searchFormName = _driver.FindElement(By.Id("new_form_search"));
        _searchFormName.SendKeys(str);
    }

    public void SubmitSearchForm()
    {
        _submitButton = _driver.FindElement(By.CssSelector("span[class=\"bth-text-layer\"]"));
        _submitButton.Click();
    }
    public ReadOnlyCollection<IWebElement> GetSearchResult()
    {
        return _driver.FindElements(By.CssSelector("div[class=\"search-results__items\"]"));
    }
    
}