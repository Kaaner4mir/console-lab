class Area
{
    public static void AreaOperation()
    {
        try
        {
            Console.Clear();
            Menu.DisplayAreaMenu();
            short choice = ConsoleHelper.GetInput<short>("\n👉 Select the action you want to perform : ");

            switch (choice)
            {
                case 1: CircleCalculate(); break;
                case 2: TriangleCalculate(); break;
                case 3: SquareCalculate(); break;
                case 4: RectangleCalculate(); break;
                case 5: OtherCalculate(); break;
                default: ConsoleHelper.WriteColored("\n❓ The operation you attempted failed.", ConsoleColor.Yellow); break;
            }
        }
        catch (Exception exc)
        {
            ConsoleHelper.WriteColored($"\n⚠️ An error has occurred : {exc.Message}", ConsoleColor.Red);
            return;
        }
    }

    public static void CircleCalculate()
    {
        double semiDiameter = ConsoleHelper.GetInput<double>("\n📏 Enter the semi-diameter : ");

        if (semiDiameter < 0)
        {
            ConsoleHelper.WriteColored("\n⛔ Please enter a valid value!", ConsoleColor.Yellow);
            return;
        }

        double result = Math.PI * Math.Pow(semiDiameter, 2);

        ShowResult(result);
    }

    public static void TriangleCalculate()
    {
        double baselenght = ConsoleHelper.GetInput<double>("\n📏 Enter the base : ");

        if (baselenght < 0)
        {
            ConsoleHelper.WriteColored("\n⛔ Please enter a valid value!", ConsoleColor.Yellow);
            return;
        }

        double height = ConsoleHelper.GetInput<double>("\n📏 Enter the height : ");

        if (height < 0)
        {
            ConsoleHelper.WriteColored("\n⛔ Please enter a valid value!", ConsoleColor.Yellow);
            return;
        }

        double result = 0.5 * baselenght * height;

        ShowResult(result);
    }

    public static void SquareCalculate()
    {
        double edgeLenght = ConsoleHelper.GetInput<double>("\n📏 Enter the edge lenght : ");

        if (edgeLenght < 0)
        {
            ConsoleHelper.WriteColored("\n⛔ Please enter a valid value!", ConsoleColor.Yellow);
            return;
        }

        double result = Math.Pow(edgeLenght, 2);

        ShowResult(result);
    }

    public static void RectangleCalculate()
    {
        double shortEdgeLenght = ConsoleHelper.GetInput<double>("\n📏 Enter the short edge lenght : ");

        if (shortEdgeLenght < 0)
        {
            ConsoleHelper.WriteColored("\n⛔ Please enter a valid value!", ConsoleColor.Yellow);
            return;
        }

        double longEdgeLenght = ConsoleHelper.GetInput<double>("\n📏 Enter the long edge lenght : ");

        if (longEdgeLenght < 0)
        {
            ConsoleHelper.WriteColored("\n⛔ Please enter a valid value!", ConsoleColor.Yellow);
            return;
        }

        double result = shortEdgeLenght * longEdgeLenght;

        ShowResult(result);
    }

    public static void OtherCalculate()
    {
        double numberOfEdges = ConsoleHelper.GetInput<double>("\n📏 Enter the number of edges : ");

        if (numberOfEdges < 5)
        {
            ConsoleHelper.WriteColored("\n⛔ Please enter a valid value!", ConsoleColor.Yellow);
            return;
        }

        double sideLenght = ConsoleHelper.GetInput<double>("\n📏 Enter the side lenght : ");

        if (sideLenght < 0)
        {
            ConsoleHelper.WriteColored("\n⛔ Please enter a valid value!", ConsoleColor.Yellow);
            return;
        }

        double result = (numberOfEdges * Math.Pow(sideLenght, 2) / (4 * Math.Tan(Math.PI / numberOfEdges)));

        ShowResult(result);
    }

    public static void ShowResult(double result)
    {
        ConsoleHelper.WriteColored($"\n✅ Area of the shape : {result}", ConsoleColor.Green);
    }

}