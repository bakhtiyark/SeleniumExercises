namespace SeleniumExercise;

internal abstract class Pages : BaseTest
{
    private static HomePage Home = null!;
    private static CareersPage Careers = null!;

    public static void Init(IWebDriver driver)
    {
        Home = new HomePage(driver);
        Careers = new CareersPage(driver);
    }

    public static void SearchPosition(TestData testData)
    {
        Home.OpenCareersPage(); 
        Careers.SearchPosition(testData);
    }
}