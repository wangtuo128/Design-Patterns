namespace Applied;

public class ChemistryBookContentProvider : IBookContentProvider
{
    public string GetContent()
    {
        return "Chemistry book content: Organic Chemistry, Inorganic Chemistry, Physical Chemistry";
    }
}