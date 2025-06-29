namespace Applied;

public interface IBook
{
    IBookContentProvider BookContentProvider { get; }
    void Publish();
}
