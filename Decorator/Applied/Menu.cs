namespace Applied;

public class Menu : IMenu
{
    private readonly List<MenuItem> _menuItems;
    public virtual List<MenuItem> MenuItems => _menuItems;

    public Menu(List<MenuItem> menuItems)
    {
        _menuItems = menuItems;
    }
}