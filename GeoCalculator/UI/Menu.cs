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
<<<<<<< HEAD

    public static void DisplayVolumeMenu()
    {
        var mainMenuItems = new (string Text, ConsoleColor Color)[]
       {
            (" ----- ⭕ Volume Calculation Menu -----\n", ConsoleColor.Cyan),
            (" 1. Cube", ConsoleColor.White),
            (" 2. Rectangular Prism", ConsoleColor.Gray),
            (" 3. Square Prism", ConsoleColor.DarkGray),
            (" 4. General Prism", ConsoleColor.Yellow),
            (" 5. Cylinder", ConsoleColor.DarkYellow),
            (" 6. Cone", ConsoleColor.Red),
            (" 7. Frustum of a cone", ConsoleColor.DarkRed),
            (" 8. Sphere", ConsoleColor.Green),
            (" 9. Spherical Sector", ConsoleColor.DarkGreen),
            ("10. Spherical Cap", ConsoleColor.Blue),
            ("11. Square Pyramid", ConsoleColor.DarkBlue),
            ("12. Rectangular Pyramid", ConsoleColor.Magenta),
            ("13. General Pyramid", ConsoleColor.DarkMagenta),
       };

        foreach (var item in mainMenuItems)
        {
            ConsoleHelper.WriteColored(item.Text, item.Color);
        }
    }
=======
>>>>>>> 4c978f365df4551f59cd3e74087c3de582cdd2b6
}