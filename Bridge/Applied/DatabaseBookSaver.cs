namespace Applied;

public class DatabaseBookSaver : IBookSaver
{
    public IBookContentProvider BookContentProvider { get; }

    public DatabaseBookSaver(IBookContentProvider bookContentProvider)
    {
        BookContentProvider = bookContentProvider;
    }
    public void Save()
    {
        string content = BookContentProvider.GetContent();
        Console.WriteLine("Book content saved to database: " + content);
    }
}