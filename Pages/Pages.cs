namespace SeleniumExercise;

internal abstract class Pages : BaseTest
{
    private static HomePage Home = null!;
    private static CareersPage Careers = null!;
    private static SearchResultsPage Search = null!;
    private static PositionPage JobPosting = null!;


    public static void Init(IWebDriver driver)
    {
        Home = new HomePage(driver);
        Careers = new CareersPage(driver);
        Search = new SearchResultsPage(driver);
        JobPosting = new PositionPage(driver);
    }

    public static void SearchPosition(TestData testData)
    {
        Home.OpenCareersPage(); 
        Careers.SearchPosition(testData);
    }

    public static void SelectLastPosition()
    {
        Search.SelectLastElement();
    }

    public static string GetJobPostingTitle()
    {
        return JobPosting.GetJobTitle();
    }
}