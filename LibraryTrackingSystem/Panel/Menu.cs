class Menu
{
    public static void DisplayMainMenu()
    {
        var mainMenuItems = new (string Text, ConsoleColor Color)[]
        {
            (" ----- 📚 Main Menu -----\n", ConsoleColor.DarkCyan),
            (" 1. List the books", ConsoleColor.White),
            (" 2. Add a book", ConsoleColor.Red),
            (" 3. Update the book", ConsoleColor.Blue),
            (" 4. Remove the book", ConsoleColor.Magenta),
        };

        foreach (var item in mainMenuItems)
        {
            ConsoleHelper.WriteColored(item.Text, item.Color);
        }
    }

    public static void DisplayUpdateMenu()
    {
        var mainMenuItems = new (string Text, ConsoleColor Color)[]
        {
            (" ----- 🔃 Update Menu -----\n", ConsoleColor.DarkCyan),
            (" 1. Book Name", ConsoleColor.White),
            (" 2. Author", ConsoleColor.Yellow),
            (" 3. Publisher", ConsoleColor.Red),
            (" 4. Publication Year", ConsoleColor.Green),
            (" 5. Genre", ConsoleColor.Blue),
            (" 6. Language", ConsoleColor.Magenta),
            (" 7. Page Count", ConsoleColor.DarkMagenta),
        };

        foreach (var item in mainMenuItems)
        {
            ConsoleHelper.WriteColored(item.Text, item.Color);
        }
    }
}