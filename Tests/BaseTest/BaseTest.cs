using OpenQA.Selenium.Chrome;
using SeleniumExercise.Constants;
using SeleniumExercise;

public class BaseTest
{
    private IWebDriver _driver;


    [SetUp]
    public void TestSetup()
    {
        Logger.ConfigureLogging();
        _driver = new ChromeDriver();
        _driver.Manage().Window.Maximize();
        _driver.Url = Constants.WEBSITE;
        _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Constants.WAIT_TIMEOUT);
        Pages.Init(_driver);
        Log.Information("Test commence");
    }

    [TearDown]
    public void TestEnding()
    {
        Log.Information("Tests completed");
        _driver.Quit();
    }
}