using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExercise.Constants;
using SeleniumExercise;
public class BaseTest
    {
        private IWebDriver driver;


        [SetUp]
        public void TestSetup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = Constants.WEBSITE;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Constants.WAIT_TIMEOUT);
            Pages.Init(driver);
        }

        [TearDown]
        public void TestEnding()
        {
            driver.Quit();
        }
    }
