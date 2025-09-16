class Menu
{
    public static void DisplayMainMenu()
    {
        var mainMenuItems = new (string Text, ConsoleColor Color)[]
        {
            (" ----- 📚 Main Menu -----\n", ConsoleColor.DarkCyan),
            (" 1. List the books", ConsoleColor.White),
            (" 2. Add a book", ConsoleColor.White),
            (" 3. Update the book", ConsoleColor.White),
            (" 4. Remove the book", ConsoleColor.White),
        };

        foreach (var item in mainMenuItems)
        {
            ConsoleHelper.WriteColored(item.Text, item.Color);
        }
    }
}