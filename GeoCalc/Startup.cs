using System.Text;

class Startup
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        try
        {
            while (true)
            {
                Console.Clear();
                Menu.DisplayMainMenu();
                short choice = ConsoleHelper.GetInput<short>("\n👉 Select the action you want to perform : ");

                switch (choice)
                {
                    case 1: Perimeter.Main(); break;
                }
                ConsoleHelper.WaitingScreen();
            }
        }
        catch (Exception exc)
        {
            ConsoleHelper.WriteColored($"\n⚠️ An error occurred : {exc.Message}");
        }
    }
}