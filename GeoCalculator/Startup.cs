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
                Console.WriteLine();

                switch (choice)
                {
                    case 1: Perimeter.PerimeterOperation(); break;
                    case 2: Area.AreaOperation(); break;
                    case 3: Volume.VolumeOperation(); break;
                    default: ConsoleHelper.WriteColored("❓ The operation you attempted failed.", ConsoleColor.Yellow); break;
                }
                ConsoleHelper.WaitingScreen();
                ConsoleHelper.SpinnerAnimation();
            }
        }
        catch (Exception exc)
        {
            ConsoleHelper.WriteColored($"\n⚠️ An error has occurred : {exc.Message}", ConsoleColor.Red);
        }
    }
}