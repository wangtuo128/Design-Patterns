namespace Not_Applied;

public class MathPrintBookWithSavingToDatabase : PrintBookWithSavingToDatabase
{
    public override string GetContent()
    {
        return "Math book content: Algebra, Geometry, Calculus";
    }

    public override void Save()
    {
        Console.WriteLine("Math book content saved to database: " + GetContent());
    }
}