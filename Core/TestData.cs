namespace SeleniumExercise.Core;

public class TestData
{
    public readonly string DesiredLanguage;
    public readonly bool Remote;
    public readonly List<string> SearchItemsList;
    public readonly string SearchString;

    public TestData()
    {
        DesiredLanguage = "Java";
        Remote = true;
        SearchItemsList = ["blockchain", "automation", "cloud"];
        SearchString = SearchItemsList.Aggregate("", (current, item) => current + item + " ");
    }
}