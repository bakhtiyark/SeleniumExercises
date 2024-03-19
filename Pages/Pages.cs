namespace SeleniumExercise;

internal abstract class Pages : BaseTest
{
    internal static HomePage Home = null!;
    private static CareersPage _careers = null!;
    private static SearchResultsPage _search = null!;
    private static PositionPage _jobPosting = null!;

    public static void Init(IWebDriver driver)
    {
        Home = new HomePage(driver);
        _careers = new CareersPage(driver);
        _search = new SearchResultsPage(driver);
        _jobPosting = new PositionPage(driver);
    }

    public static void SearchPosition(TestData testData)
    {
        Home.OpenCareersPage();
        _careers.SearchPosition(testData);
    }

    public static void SelectLastPosition()
    {
        _search.SelectLastElement();
    }

    public static string GetJobPostingTitle()
    {
        return _jobPosting.GetJobTitle();
    }

    public static void SearchForInfo(string str)
    {
        Home.ClickMagnifyingGlassIcon();
        Home.FillSearchItem(str);
        Home.SubmitSearchForm();
    }
}