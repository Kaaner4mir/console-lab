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
                case 8: SphereCalculate(); break;
                case 9: SphericalSectorCalculate(); break;
                case 10: SphericalCapCalculate(); break;
                case 11: SquarePyramidCalculate(); break;
                case 12: RectangularPyramidCalculate(); break;
                case 13: GeneralPyramidCalculate(); break;
                default: ConsoleHelper.WriteColored("\n❓ The operation you attempted failed.", ConsoleColor.Yellow); break;
            }
        }
        catch (Exception exc)
        {
            ConsoleHelper.WriteColored($"\n⚠️ An error has occurred : {exc.Message}", ConsoleColor.Red);
        }
    }

    // ----------------------- Cube -----------------------
    public static void CubeCalculate()
    {
        double a = ConsoleHelper.GetInput<double>("\n📏 Enter the edge length (a) : ");
        if (a < 0) { ConsoleHelper.WriteColored("\n⛔ Please enter a valid value!", ConsoleColor.Yellow); return; }

        double result = Math.Pow(a, 3);
        ShowResult(result);
    }

    // ----------------------- Rectangular Prism -----------------------
    public static void RectangularPrismCalculate()
    {
        double a = ConsoleHelper.GetInput<double>("\n📏 Enter the length (a) : ");
        double b = ConsoleHelper.GetInput<double>("\n📏 Enter the width (b) : ");
        double h = ConsoleHelper.GetInput<double>("\n📏 Enter the height (h) : ");

        if (a < 0 || b < 0 || h < 0) { ConsoleHelper.WriteColored("\n⛔ Please enter valid values!", ConsoleColor.Yellow); return; }

        double result = a * b * h;
        ShowResult(result);
    }

    // ----------------------- Square Prism -----------------------
    public static void SquarePrismCalculate()
    {
        double a = ConsoleHelper.GetInput<double>("\n📏 Enter the base edge (a) : ");
        double h = ConsoleHelper.GetInput<double>("\n📏 Enter the height (h) : ");

        if (a < 0 || h < 0) { ConsoleHelper.WriteColored("\n⛔ Please enter valid values!", ConsoleColor.Yellow); return; }

        double result = Math.Pow(a, 2) * h;
        ShowResult(result);
    }

    // ----------------------- General Prism -----------------------
    public static void GeneralPrismCalculate()
    {
        double baseArea = ConsoleHelper.GetInput<double>("\n📏 Enter the base area : ");
        double h = ConsoleHelper.GetInput<double>("\n📏 Enter the height (h) : ");

        if (baseArea < 0 || h < 0) { ConsoleHelper.WriteColored("\n⛔ Please enter valid values!", ConsoleColor.Yellow); return; }

        double result = baseArea * h;
        ShowResult(result);
    }

    // ----------------------- Cylinder -----------------------
    public static void CylinderCalculate()
    {
        double r = ConsoleHelper.GetInput<double>("\n📏 Enter the radius (r) : ");
        double h = ConsoleHelper.GetInput<double>("\n📏 Enter the height (h) : ");

        if (r < 0 || h < 0) { ConsoleHelper.WriteColored("\n⛔ Please enter valid values!", ConsoleColor.Yellow); return; }

        double result = Math.PI * Math.Pow(r, 2) * h;
        ShowResult(result);
    }

    // ----------------------- Cone -----------------------
    public static void ConeCalculate()
    {
        double r = ConsoleHelper.GetInput<double>("\n📏 Enter the radius (r) : ");
        double h = ConsoleHelper.GetInput<double>("\n📏 Enter the height (h) : ");

        if (r < 0 || h < 0) { ConsoleHelper.WriteColored("\n⛔ Please enter valid values!", ConsoleColor.Yellow); return; }

        double result = (Math.PI * Math.Pow(r, 2) * h) / 3.0;
        ShowResult(result);
    }

    // ----------------------- Truncated Cone -----------------------
    public static void TruncatedConeCalculate()
    {
        double R = ConsoleHelper.GetInput<double>("\n📏 Enter the big radius (R) : ");
        double r = ConsoleHelper.GetInput<double>("\n📏 Enter the small radius (r) : ");
        double h = ConsoleHelper.GetInput<double>("\n📏 Enter the height (h) : ");

        if (R < 0 || r < 0 || h < 0) { ConsoleHelper.WriteColored("\n⛔ Please enter valid values!", ConsoleColor.Yellow); return; }

        double result = (Math.PI * h * (R * R + R * r + r * r)) / 3.0;
        ShowResult(result);
    }

    // ----------------------- Sphere -----------------------
    public static void SphereCalculate()
    {
        double r = ConsoleHelper.GetInput<double>("\n📏 Enter the radius (r) : ");
        if (r < 0) { ConsoleHelper.WriteColored("\n⛔ Please enter a valid value!", ConsoleColor.Yellow); return; }

        double result = (4.0 / 3.0) * Math.PI * Math.Pow(r, 3);
        ShowResult(result);
    }

    // ----------------------- Spherical Sector -----------------------
    public static void SphericalSectorCalculate()
    {
        double r = ConsoleHelper.GetInput<double>("\n📏 Enter the sphere radius (r) : ");
        double h = ConsoleHelper.GetInput<double>("\n📏 Enter the sector height (h) : ");

        if (r < 0 || h < 0) { ConsoleHelper.WriteColored("\n⛔ Please enter valid values!", ConsoleColor.Yellow); return; }

        double result = (1.0 / 3.0) * Math.PI * Math.Pow(h, 2) * (3 * r - h);
        ShowResult(result);
    }

    // ----------------------- Spherical Cap -----------------------
    public static void SphericalCapCalculate()
    {
        double a = ConsoleHelper.GetInput<double>("\n📏 Enter the cap radius (a) : ");
        double h = ConsoleHelper.GetInput<double>("\n📏 Enter the cap height (h) : ");

        if (a < 0 || h < 0) { ConsoleHelper.WriteColored("\n⛔ Please enter valid values!", ConsoleColor.Yellow); return; }

        double result = (Math.PI * h * (3 * Math.Pow(a, 2) + Math.Pow(h, 2))) / 6.0;
        ShowResult(result);
    }

    // ----------------------- Square Pyramid -----------------------
    public static void SquarePyramidCalculate()
    {
        double a = ConsoleHelper.GetInput<double>("\n📏 Enter the base edge (a) : ");
        double h = ConsoleHelper.GetInput<double>("\n📏 Enter the height (h) : ");

        if (a < 0 || h < 0) { ConsoleHelper.WriteColored("\n⛔ Please enter valid values!", ConsoleColor.Yellow); return; }

        double result = (Math.Pow(a, 2) * h) / 3.0;
        ShowResult(result);
    }

    // ----------------------- Rectangular Pyramid -----------------------
    public static void RectangularPyramidCalculate()
    {
        double a = ConsoleHelper.GetInput<double>("\n📏 Enter the base length (a) : ");
        double b = ConsoleHelper.GetInput<double>("\n📏 Enter the base width (b) : ");
        double h = ConsoleHelper.GetInput<double>("\n📏 Enter the height (h) : ");

        if (a < 0 || b < 0 || h < 0) { ConsoleHelper.WriteColored("\n⛔ Please enter valid values!", ConsoleColor.Yellow); return; }

        double result = (a * b * h) / 3.0;
        ShowResult(result);
    }

    // ----------------------- General Pyramid -----------------------
    public static void GeneralPyramidCalculate()
    {
        double baseArea = ConsoleHelper.GetInput<double>("\n📏 Enter the base area : ");
        double h = ConsoleHelper.GetInput<double>("\n📏 Enter the height (h) : ");

        if (baseArea < 0 || h < 0) { ConsoleHelper.WriteColored("\n⛔ Please enter valid values!", ConsoleColor.Yellow); return; }

        double result = (baseArea * h) / 3.0;
        ShowResult(result);
    }

    // ----------------------- Show Result -----------------------
    public static void ShowResult(double result)
    {
        ConsoleHelper.WriteColored($"\n✅ Volume of the shape : {result}", ConsoleColor.Green);
    }
}
