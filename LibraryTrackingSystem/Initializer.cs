using System.Text;

class Initializer
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Title = "📚 Library Tracking System";

        try
        {
            while (true)
            {
                Console.Clear();
                Menu.DisplayMainMenu();
                byte choice = ConsoleHelper.GetInput<byte>("\n👉 Select the operation you want to perform numerically : ");

                switch (choice)
                {
                    case 1: DataStore.List(); break;
                    case 2: AddBook.Add(); break;
                    case 3: UpdateBook.Update(); break;
                    default: ConsoleHelper.WriteColored("\n❓ The operation you want to perform could not be found!", ConsoleColor.Yellow); break;
                }
                ConsoleHelper.WaitingScreen();
                ConsoleHelper.SpinnerAnimation();
            }
        }
        catch (Exception ex)
        {
            ConsoleHelper.WriteColored($"\n❌ An error has occurred : {ex.Message}", ConsoleColor.Red);
        }
    }
}