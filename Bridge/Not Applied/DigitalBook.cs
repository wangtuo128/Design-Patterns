namespace Not_Applied;

public abstract class DigitalBook : IBook
{
    public abstract string GetContent();

    public void Publish()
    {
        Console.WriteLine("Digital book published. Content: " + GetContent());
    }
}