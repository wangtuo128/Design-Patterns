
namespace NotApplied;

public class Menu : IMenu
{
    private readonly List<IMenuItem> _menuItems;
    public virtual List<IMenuItem> MenuItems => _menuItems;

    public Menu(List<IMenuItem> menuItems)
    {
        _menuItems = menuItems;
    }
}