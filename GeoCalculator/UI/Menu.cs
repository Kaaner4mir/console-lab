class Menu
{
    public static void DisplayMainMenu()
    {
        var mainMenuItems = new (string Text, ConsoleColor Color)[]
        {
            (" ----- 🪧 Main Menu -----\n", ConsoleColor.Cyan),
            (" 1. Perimeter Calculation", ConsoleColor.Magenta),
            (" 2. Area Calculation", ConsoleColor.Red),
            (" 3. Volume Calculation", ConsoleColor.White),
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
            (" 1. Circle", ConsoleColor.Magenta),
            (" 2. Square", ConsoleColor.Blue),
            (" 3. Rectangle", ConsoleColor.Red),
            (" 4. Other", ConsoleColor.White),
        };

        foreach (var item in mainMenuItems)
        {
            ConsoleHelper.WriteColored(item.Text, item.Color);
        }
    }

    public static void DisplayAreaMenu()
    {
        var mainMenuItems = new (string Text, ConsoleColor Color)[]
        {
            (" ----- ⭕ Area Calculation Menu -----\n", ConsoleColor.Cyan),
            (" 1. Circle", ConsoleColor.Magenta),
            (" 2. Triangle", ConsoleColor.Blue),
            (" 3. Square", ConsoleColor.Red),
            (" 4. Rectangle", ConsoleColor.Gray),
            (" 5. Other", ConsoleColor.White),
        };

        foreach (var item in mainMenuItems)
        {
            ConsoleHelper.WriteColored(item.Text, item.Color);
        }
    }
}