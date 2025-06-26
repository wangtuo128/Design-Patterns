
namespace NotApplied;
public class ChristmasMenu : Menu
{
    public ChristmasMenu(List<IMenuItem> menuItems) : base(menuItems)
    {
    }

    public override List<IMenuItem> MenuItems => base.MenuItems.Select(i =>
    {
        i.Name += " On Christmas";

        return i;
    }).ToList();
}