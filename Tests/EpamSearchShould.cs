namespace SeleniumExercise.Tests;

public class EpamSearchShould : BaseTest
{
    private readonly TestData _testData = new();

    [Test]
    public void ReturnExpectedJob()
    {
        Pages.SearchPosition(_testData);
        Pages.SelectLastPosition();
        Assert.That(Pages.GetJobPostingTitle(), Does.Contain(_testData.DesiredLanguage));
    }

    [Test]
    public void ContainExpectedStrings()
    {
        Pages.SearchForInfo(_testData.SearchString);
        var result = Pages.Home.GetSearchResult();
        var everyElementMatches = result.All(element =>
            _testData.SearchItemsList.Any(str => element.Text.Contains(str)));

        Assert.That(everyElementMatches, Is.True);
    }
}