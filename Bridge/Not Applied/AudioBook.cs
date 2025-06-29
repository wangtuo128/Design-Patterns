namespace Not_Applied;

public abstract class AudioBook : IBook
{
    public abstract string GetContent();

    public void Publish()
    {
        Console.WriteLine("Audio book published. Content: " + GetContent());
    }
}