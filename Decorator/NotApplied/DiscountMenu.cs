
namespace NotApplied;

public class DiscountMenu : Menu
{
    private readonly double _discount;
    public DiscountMenu(List<IMenuItem> menuItems, double discount) : base(menuItems)
    {
        _discount = discount;
    }

    public override List<IMenuItem> MenuItems => base.MenuItems.Select(i =>
    {
        i.Price *= _discount;
        return i;
    }).ToList();
}