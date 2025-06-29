namespace Applied;

public interface IBookSaver
{
    IBookContentProvider BookContentProvider { get; }
    void Save();
}