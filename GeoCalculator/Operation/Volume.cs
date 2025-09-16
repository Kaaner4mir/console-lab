class Volume
{
    public static void VolumeOperation()
    {
        try
        {
            Console.Clear();
            Menu.DisplayVolumeMenu();
            short choice = ConsoleHelper.GetInput<short>("\n👉 Select the action you want to perform : ");

            switch (choice)
            {
                case 1: CubeCalculate(); break;
                case 2: RectangularPrismCalculate(); break;
                case 3: SquarePrismCalculate(); break;
                case 4: GeneralPrismCalculate(); break;
                case 5: CylinderCalculate(); break;
                case 6: ConeCalculate(); break;
                case 7: TruncatedConeCalculate(); break;
                default: ConsoleHelper.WriteColored("\n❓ The operation you attempted failed.", ConsoleColor.Yellow); break;
            }
        }
        catch (Exception exc)
        {
            ConsoleHelper.WriteColored($"\n⚠️ An error has occurred : {exc.Message}", ConsoleColor.Red);
        }
    }

    public static void CubeCalculate()
    {
        double edgeLenght = ConsoleHelper.GetInput<double>("\n📏 Enter the edge lenght : ");

        if (edgeLenght < 0)
        {
            ConsoleHelper.WriteColored("\n⛔ Please enter a valid value!", ConsoleColor.Yellow);
            return;
        }

        double result = Math.Pow(edgeLenght, 3);

        ShowResult(result);
    }

    public static void RectangularPrismCalculate()
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

        double height = ConsoleHelper.GetInput<double>("\n📏 Enter the height : ");

        if (height < 0)
        {
            ConsoleHelper.WriteColored("\n⛔ Please enter a valid value!", ConsoleColor.Yellow);
            return;
        }

        double result = shortEdgeLenght * longEdgeLenght * height;

        ShowResult(result);
    }

    public static void SquarePrismCalculate()
    {
        double edgeLenght = ConsoleHelper.GetInput<double>("\n📏 Enter the edge lenght : ");

        if (edgeLenght < 0)
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

        double result = Math.Pow(edgeLenght, 2) * height;

        ShowResult(result);
    }

    public static void GeneralPrismCalculate()
    {
        double baseArea = ConsoleHelper.GetInput<double>("\n📏 Enter the base area : ");

        if (baseArea < 0)
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

        double result = baseArea * height;

        ShowResult(result);
    }

    public static void CylinderCalculate()
    {
        double r = ConsoleHelper.GetInput<double>("\n📏 Enter the radius : ");

        if (r < 0)
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

        double result = Math.PI * Math.Pow(r, 2) * height;

        ShowResult(result);
    }

    public static void ConeCalculate()
    {
        double r = ConsoleHelper.GetInput<double>("\n📏 Enter the radius : ");

        if (r < 0)
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

        double result = (Math.PI * Math.Pow(r, 2) * height) / 3.0;

        ShowResult(result);
    }

    public static void TruncatedConeCalculate()
    {
        double R = ConsoleHelper.GetInput<double>("\n📏 Enter the big radius (R): ");
        if (R < 0)
        {
            ConsoleHelper.WriteColored("\n⛔ Please enter a valid value!", ConsoleColor.Yellow);
            return;
        }

        double r = ConsoleHelper.GetInput<double>("\n📏 Enter the small radius (r): ");
        if (r < 0)
        {
            ConsoleHelper.WriteColored("\n⛔ Please enter a valid value!", ConsoleColor.Yellow);
            return;
        }

        double h = ConsoleHelper.GetInput<double>("\n📏 Enter the height (h): ");
        if (h < 0)
        {
            ConsoleHelper.WriteColored("\n⛔ Please enter a valid value!", ConsoleColor.Yellow);
            return;
        }

        double result = (Math.PI * h * (R * R + R * r + r * r)) / 3.0;

        ShowResult(result);
    }


    public static void ShowResult(double result)
    {
        ConsoleHelper.WriteColored($"\n✅ Volume of the shape : {result}", ConsoleColor.Green);
    }
}