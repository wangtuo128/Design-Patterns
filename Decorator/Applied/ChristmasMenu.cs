
namespace Applied;

public class ChrismasMenuDecorator : IMenu
{
    private readonly IMenu _menu;

    public ChrismasMenuDecorator(IMenu menu)
    {
        _menu = menu;
    }

    public List<MenuItem> MenuItems => _menu.MenuItems.Select(i =>
    {
        i.Name += " On Christmas";

        return i;
    }).ToList();
}