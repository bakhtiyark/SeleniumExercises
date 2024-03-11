using OpenQA.Selenium.Chrome;
using SeleniumExercise.Constants;
using SeleniumExercise;

public class BaseTest
{
    private IWebDriver _driver;


    [SetUp]
    public void TestSetup()
    {
        _driver = new ChromeDriver();
        _driver.Manage().Window.Maximize();
        _driver.Url = Constants.WEBSITE;
        _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Constants.WAIT_TIMEOUT);
        Pages.Init(_driver);
    }

    [TearDown]
    public void TestEnding()
    {
        _driver.Quit();
    }
}