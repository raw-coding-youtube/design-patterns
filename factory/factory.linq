<Query Kind="Program" />

void Main()
{
	new NavigationBar();
	new DropdownMenu();
}

public class NavigationBar {
	public NavigationBar() => ButtonFactory.CreateButton();
}

public class DropdownMenu
{
	public DropdownMenu() => ButtonFactory.CreateButton();
}

public class ButtonFactory
{
	public static Button CreateButton()
	{
		return new Button { Type = "Red Button".Dump() };
	}
}

public class Button
{
	public string Type { get; set; }
}
