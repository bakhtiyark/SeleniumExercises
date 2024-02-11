using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SeleniumExercise;

public class HomePage(IWebDriver driver) : BasePage(driver)
{
    
    private readonly IWebDriver _driver = driver;
    private IWebElement _careersLink = null!;
    public void OpenCareersPage()
    {
        _careersLink = _driver.FindElement(By.XPath("//*[@id=\"wrapper\"]/div[2]/div[1]/header/div/div/nav/ul/li[5]/span[1]/a")); 
        _careersLink.Click();
    }
}