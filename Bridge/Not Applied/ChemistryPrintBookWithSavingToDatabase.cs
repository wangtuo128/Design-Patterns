namespace Not_Applied;

public class ChemistryPrintBookWithSavingToDatabase : PrintBookWithSavingToDatabase
{
    public override string GetContent()
    {
        return "Chemistry book content: Organic Chemistry, Inorganic Chemistry, Physical Chemistry";
    }

    public override void Save()
    {
        Console.WriteLine("Chemistry book content saved to database: " + GetContent());
    }
}