class Perimeter
{
    public static void PerimeterOperation()
    {
        try
        {
            Console.Clear();
            Menu.DisplayPerimeterMenu();
            short choice = ConsoleHelper.GetInput<short>("\n👉 Select the action you want to perform : ");

            switch (choice)
            {
                case 1: CircleCalculate(); break;
                case 2: SquareCalculate(); break;
                case 3: RectangleCalculate(); break;
                case 4: PolygonCalculate(); break;
                default: ConsoleHelper.WriteColored("\n❓ The operation you attempted failed.", ConsoleColor.Yellow); break;
            }
        }
        catch (Exception exc)
        {
            ConsoleHelper.WriteColored($"\n⚠️ An error has occurred : {exc.Message}", ConsoleColor.Red);
        }
    }

    // ----------------------- Circle -----------------------
    public static void CircleCalculate()
    {
        double r = ConsoleHelper.GetInput<double>("\n📏 Enter the radius : ");
        if (r < 0) { ConsoleHelper.WriteColored("\n⛔ Please enter a valid value!", ConsoleColor.Yellow); return; }

        double result = 2 * Math.PI * r;
        ShowResult(result);
    }

    // ----------------------- Square -----------------------
    public static void SquareCalculate()
    {
        double side = ConsoleHelper.GetInput<double>("\n📏 Enter the side length : ");
        if (side < 0) { ConsoleHelper.WriteColored("\n⛔ Please enter a valid value!", ConsoleColor.Yellow); return; }

        double result = 4 * side;
        ShowResult(result);
    }

    // ----------------------- Rectangle -----------------------
    public static void RectangleCalculate()
    {
        double length = ConsoleHelper.GetInput<double>("\n📏 Enter the length : ");
        double width = ConsoleHelper.GetInput<double>("\n📏 Enter the width : ");

        if (length < 0 || width < 0) { ConsoleHelper.WriteColored("\n⛔ Please enter valid values!", ConsoleColor.Yellow); return; }

        double result = 2 * (length + width);
        ShowResult(result);
    }

    // ----------------------- Regular Polygon / Other -----------------------
    public static void PolygonCalculate()
    {
        short numberOfSides = ConsoleHelper.GetInput<short>("\n🔢 Enter the number of sides : ");
        if (numberOfSides <= 2) { ConsoleHelper.WriteColored("\n⛔ A polygon must have at least 3 sides!", ConsoleColor.Yellow); return; }

        double sideLength = ConsoleHelper.GetInput<double>("\n📏 Enter the side length : ");
        if (sideLength < 0) { ConsoleHelper.WriteColored("\n⛔ Please enter a valid value!", ConsoleColor.Yellow); return; }

        double result = numberOfSides * sideLength;
        ShowResult(result);
    }

    // ----------------------- Show Result -----------------------
    public static void ShowResult(double result)
    {
        ConsoleHelper.WriteColored($"\n✅ Perimeter of the shape : {result}", ConsoleColor.Green);
    }
}
