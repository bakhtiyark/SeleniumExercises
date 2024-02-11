namespace SeleniumExercise.Tests;
public class EpamSearchShould : BaseTest
{
    TestData _testData = new();
    [Test]
    public void ReturnExpectedJob()
    {
        Pages.SearchPosition(_testData);
    }
}