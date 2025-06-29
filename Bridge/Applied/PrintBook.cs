namespace Applied;

public class PrintBook : IBook
{
    public IBookContentProvider BookContentProvider { get; }

    public PrintBook(IBookContentProvider bookContentProvider)
    {
        BookContentProvider = bookContentProvider;
    }

    public void Publish()
    {
        Console.WriteLine("Print book published. Content: " + BookContentProvider.GetContent());
    }
}