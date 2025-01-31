namespace Factory
{
	public class AbstractNavigationBar
	{
		public AbstractNavigationBar(IUIFactory factory) => factory.CreateButton();
	}

	public class AbstractDropdownMenu
	{
		public AbstractDropdownMenu(IUIFactory factory) => factory.CreateButton();
	}

	public interface IUIFactory
	{
		public AbstractButton CreateButton();
	}

	public class Apple : IUIFactory
	{
		public AbstractButton CreateButton()
		{
			return new AbstractButton { Type = "iOS Button" };
		}
	}

	public class Android : IUIFactory
	{
		public AbstractButton CreateButton()
		{
			return new AbstractButton { Type = "Android Button" };
		}
	}

	public class AbstractButton
	{
		public string Type { get; set; }
	}
}
