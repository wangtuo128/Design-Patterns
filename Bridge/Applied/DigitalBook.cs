namespace Applied;

public class DigitalBook : IBook
{
    public IBookContentProvider BookContentProvider { get; }

    public DigitalBook(IBookContentProvider bookContentProvider)
    {
        BookContentProvider = bookContentProvider;
    }
    public void Publish()
    {
        Console.WriteLine("Digital book published. Content: " + BookContentProvider.GetContent());
    }
}