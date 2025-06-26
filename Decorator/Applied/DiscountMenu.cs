namespace Applied;

public class DiscountMenu : IMenu
{
    private readonly List<MenuItem> _menuItems;
    private readonly double _discount;

    public DiscountMenu(List<MenuItem> menuItems, double discount)
    {
        _menuItems = menuItems;
        _discount = discount;
    }

    public List<MenuItem> MenuItems => _menuItems.Select(i =>
    {
        i.Price *= _discount;
        return i;
    }).ToList();
}