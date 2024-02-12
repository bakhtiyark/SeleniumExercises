namespace SeleniumExercise.Tests;
public class EpamSearchShould : BaseTest
{
    readonly TestData _testData = new();
    [Test]
    public void ReturnExpectedJob()
    {
        Pages.SearchPosition(_testData);
        Pages.SelectLastPosition();
        Assert.That(Pages.GetJobPostingTitle(), Does.Contain(_testData.DesiredLanguage));
    }
}