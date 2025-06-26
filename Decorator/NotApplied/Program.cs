using Applied;

List<MenuItem> menuItems = [
    new MenuItem("Fish", 9.9),
    new MenuItem("Meat", 5.9)
];

var menu = new Menu(menuItems);

var discountMenu = new DiscountMenu(menuItems, 0.88);

var christmasMenu = new ChrismasMenuDecorator(menu);

var christmasMenuWithDiscount = new ChrismasMenuDecorator(discountMenu);

foreach (var menuItem in christmasMenu.MenuItems)
{
    Console.WriteLine($"{menuItem.Name}, {menuItem.Price}");
}

foreach (var menuItem in christmasMenuWithDiscount.MenuItems)
{
    Console.WriteLine($"{menuItem.Name}, {menuItem.Price}");
}
