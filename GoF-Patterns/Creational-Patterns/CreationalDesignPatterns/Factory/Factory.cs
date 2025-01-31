namespace Factory
{
	public class NavigationBar
	{
		public NavigationBar() => ButtonFactory.CreateButton();
	}

	public class DropdownMenu
	{
		public DropdownMenu() => ButtonFactory.CreateButton();
	}

	public class ButtonFactory
	{
		public static AbstractButton CreateButton()
		{
			return new AbstractButton { Type = "Red Button" };
		}
	}

	public class AbstractButton
	{
		public string Type { get; set; }
	}
}
