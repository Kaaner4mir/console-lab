class Menu
{
    public static void DisplayMainMenu()
    {
        var mainMenuItems = new (string Text, ConsoleColor Color)[]
        {
            (" ----- 🪧 Main Menu -----\n", ConsoleColor.Cyan),
            (" 1. Perimeter Calculation", ConsoleColor.Yellow),
            (" 2. Area Calculation", ConsoleColor.Yellow),
            (" 3. Volume Calculation", ConsoleColor.Yellow),
        };

        foreach (var item in mainMenuItems)
        {
            ConsoleHelper.WriteColored(item.Text, item.Color);
        }
    }

    public static void DisplayPerimeterMenu()
    {
        var mainMenuItems = new (string Text, ConsoleColor Color)[]
        {
            (" ----- ⭕ Perimeter Calculation Menu -----\n", ConsoleColor.Cyan),
            (" 1. Circle", ConsoleColor.Yellow),
            (" 2. Triangle", ConsoleColor.Yellow),
            (" 3. Square", ConsoleColor.Yellow),
            (" 4. Other", ConsoleColor.Yellow),
        };

        foreach (var item in mainMenuItems)
        {
            ConsoleHelper.WriteColored(item.Text, item.Color);
        }
    }
}