using Factory;

// Simple Factory
static void Factory()
{
	new NavigationBar();
	new DropdownMenu();
}

// In this exemple abstraction is used and injection trhough the constructor to pass the
// concrete type that will create the button
static void AbstractFactory()
{
	new AbstractNavigationBar(new Android());
	new AbstractDropdownMenu(new Android());

	new AbstractNavigationBar(new Apple());
	new AbstractDropdownMenu(new Apple());
}

// In this case an abstract class is created and then an implementation of the certain type 
// of button which will have own implementation of the method that will create the button
static void FactoryMethod()
{
	new NavigationBar();
	new DropdownMenu();
	new AndroidNavigationBar();
	new AndroidDropdownMenu();
}