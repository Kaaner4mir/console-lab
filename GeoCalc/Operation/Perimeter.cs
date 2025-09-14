class Perimeter
{
    public static void Main()
    {
		try
		{
			Console.Clear();
			Menu.DisplayPerimeterMenu();
            short choice = ConsoleHelper.GetInput<short>("\n👉 Select the action you want to perform : ");

			switch (choice)
			{
				case 1:break;
			}
        }
        catch (Exception)
		{

			throw;
		}
    }
}