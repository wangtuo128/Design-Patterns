namespace NotApplied;

public class ChristmasMenuWithDiscount : DiscountMenu
{
    public ChristmasMenuWithDiscount(List<IMenuItem> menuItems, double discount) : base(menuItems, discount)
    {
    }

    public override List<IMenuItem> MenuItems => base.MenuItems.Select(i =>
    {
        i.Name += " On Christmas";
        return i;
    }).ToList();
}