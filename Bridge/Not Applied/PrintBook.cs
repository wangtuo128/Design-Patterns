namespace Not_Applied;

public abstract class PrintBook : IBook
{
    public abstract string GetContent();

    public void Publish()
    {
        Console.WriteLine("Print book published. Content: " + GetContent());
    }
}