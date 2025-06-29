namespace Applied;

public class AudioBook : IBook
{
   public IBookContentProvider BookContentProvider { get; }

    public AudioBook(IBookContentProvider bookContentProvider)
    {
        BookContentProvider = bookContentProvider;
    }
    public void Publish()
    {
        Console.WriteLine("Audio book published. Content: " + BookContentProvider.GetContent());
    }
}