﻿namespace SeleniumExercise;
public class BasePage
{
    protected Helpers Helper { get; }
    protected BasePage(IWebDriver driver)
    {
        Helper = new Helpers(driver);
    }
}