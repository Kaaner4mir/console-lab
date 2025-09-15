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
                case 4: OtherCalculate(); break;
            }
        }
        catch (Exception exc)
        {
            ConsoleHelper.WriteColored($"\n⚠️ An error has occurred : {exc.Message}", ConsoleColor.Red);

        }
    }

    public static void CircleCalculate()
    {
        double r = ConsoleHelper.GetInput<double>("\n📏 Enter radius : ");

        if (r < 0)
        {
            ConsoleHelper.WriteColored("\n⛔ Please enter a valid value!", ConsoleColor.Yellow);
            return;
        }

        double result = 2 * Math.PI * r;
        ShowResult(result);
    }

    public static void SquareCalculate()
    {
        double sideLenght = ConsoleHelper.GetInput<double>("\n📏 Enter the side length : ");

        if (sideLenght < 0)
        {
            ConsoleHelper.WriteColored("\n⛔ Please enter a valid value!", ConsoleColor.Yellow);
            return;
        }

        double result = 4 * sideLenght;
        ShowResult(result);
    }

    public static void RectangleCalculate()
    {
        double shortLenght = ConsoleHelper.GetInput<double>("\n📏 Enter the short side length : ");

        if (shortLenght < 0)
        {
            ConsoleHelper.WriteColored("\n⛔ Please enter a valid value!", ConsoleColor.Yellow);
            return;
        }
        double longLenght = ConsoleHelper.GetInput<double>("\n📏 Enter the long side length : ");

        if (longLenght < 0)
        {
            ConsoleHelper.WriteColored("\n⛔ Please enter a valid value!", ConsoleColor.Yellow);
            return;
        }

        double result = 2 * shortLenght + 2 * longLenght;
        ShowResult(result);
    }

    public static void OtherCalculate()
    {
        short numberOfEdges = ConsoleHelper.GetInput<short>("\n🔢 Enter the number of sides : ");

        if (numberOfEdges < 0)
        {
            ConsoleHelper.WriteColored("\n⛔ Please enter a valid value!", ConsoleColor.Yellow);
            return;
        }

        short edgeLenght = ConsoleHelper.GetInput<short>("\n📏 Enter the side length : ");

        if (edgeLenght < 0)
        {
            ConsoleHelper.WriteColored("\n⛔ Please enter a valid value!", ConsoleColor.Yellow);
            return;
        }

        double result = numberOfEdges * edgeLenght;

        ShowResult(result);
    }

    public static void ShowResult(double result)
    {
        ConsoleHelper.WriteColored($"\n✅ Perimeter of the shape : {result}", ConsoleColor.Green);
    }
}