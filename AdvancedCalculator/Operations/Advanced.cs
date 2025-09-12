class Advanced
{
    public static double Exponentiation(Func<double, double, double> operation)
    {
        try
        {
            double baseNum = ConsoleHelper.GetInput<double>("➡️ Enter the base number : ");
            double exponent = ConsoleHelper.GetInput<double>("➡️ Enter the exponent : ");

            if (baseNum == 0 && exponent == 0)
            {
                ConsoleHelper.WriteColored("\n❓ Undefined!", ConsoleColor.Red);
                return double.NaN;
            }

            double result = operation(baseNum, exponent);

            return ShowResult(result);
        }
        catch (Exception exc)
        {
            ConsoleHelper.WriteColored($"\n⛔ Error : {exc.Message}", ConsoleColor.DarkRed);
            return double.NaN;
        }
    }

    public static double Root(Func<double, double, double> operation)
    {
        double radicand = ConsoleHelper.GetInput<double>("➡️ Enter the radicand : ");
        double degree = ConsoleHelper.GetInput<double>("➡️ Enter the degree : ");

        if (degree == 0)
        {
            ConsoleHelper.WriteColored("\n❗ The root degree cannot be 0!", ConsoleColor.Red);
            return double.NaN;
        }

        if (radicand < 0 && degree % 2 == 0)
        {
            ConsoleHelper.WriteColored("\n❗ The root cannot be negative for a second-degree root.", ConsoleColor.Red);
            return double.NaN;
        }

        if (radicand == 0 && degree < 0)
        {
            ConsoleHelper.WriteColored("\n❗ The root cannot be zero for a negative degree.", ConsoleColor.Red);
            return double.NaN;
        }

        double result = operation(radicand, degree);

        return ShowResult(result);
    }

    public static void Factorial()
    {
        try
        {
            int choice = ConsoleHelper.GetInput<int>("➡️ Faktöriyelini istediğiniz sayıyı giriniz : ");

            long result = 1;

            if (choice < 0)
            {
                ConsoleHelper.WriteColored("\n❗ Enter a positive number", ConsoleColor.Red);
                return;
            }

            for (int i = choice; i > 0; i--)
            {
                result *= i;
            }

            ConsoleHelper.WriteColored($"\n✅ {choice}! : {result}", ConsoleColor.Green);
        }
        catch (Exception exc)
        {
            ConsoleHelper.WriteColored($"\n⛔ Error : {exc.Message}", ConsoleColor.DarkRed);
        }

    }

    public static double Modulo(Func<double, double, double> operation)
    {
        try
        {
            double divided = ConsoleHelper.GetInput<double>("➡️ Enter the number to be divided : ");
            double divisior = ConsoleHelper.GetInput<double>("➡️ Enter the divisor : ");

            if (divided == 0 && divisior == 0)
            {
                ConsoleHelper.WriteColored("\n❓ Undefined!", ConsoleColor.Red);
                return double.NaN;
            }
            if (divisior == 0)
            {
                ConsoleHelper.WriteColored("\n❗ Divisior cannot be 0!", ConsoleColor.Red);
                return double.NaN;
            }

            double result = operation(divided, divisior);

            return ShowResult(result);
        }
        catch (Exception exc)
        {
            ConsoleHelper.WriteColored($"\n⛔ Error : {exc.Message}", ConsoleColor.DarkRed);
            return double.NaN;
        }
    }

    public static void TrigonometryInitializer()
    {
        try
        {
            Console.Clear();

            Menu.TrigonometryMenu();
            short choice = ConsoleHelper.GetInput<short>("\n👉 Select the action you want to perform : ");
            Console.WriteLine();

            switch (choice)
            {
                case 1: Trigonometry("sine"); break;
                case 2: Trigonometry("cos"); break;
                case 3: Trigonometry("tan"); break;
                case 4: Trigonometry("cot"); break;
                case 5: Trigonometry("sec"); break;
                case 6: Trigonometry("csc"); break;
                default: ConsoleHelper.WriteColored("\n❗ Please enter a valid transaction number!", ConsoleColor.Red); break;
            }
        }
        catch (Exception exc)
        {
            ConsoleHelper.WriteColored($"\n⛔ Error : {exc.Message}", ConsoleColor.DarkRed);
        }
    }

    public static void Trigonometry(string operationName)
    {
        try
        {
            double degree = ConsoleHelper.GetInput<double>("➡️ Enter the degree : ");
            double radian = degree * (Math.PI / 180);

            double result = operationName.ToLower() switch
            {
                "sine" => Math.Sin(radian),
                "cos" => Math.Cos(radian),
                "tan" => Math.Tan(radian),
                "cot" => Math.Cos(radian) / Math.Sin(radian),
                "sec" => 1 / Math.Cos(radian),
                "cose" or "csc" => 1 / Math.Sin(radian),
                _ => double.NaN
            };
            ConsoleHelper.WriteColored($"\n📌 {operationName}({degree}°) = {result}", ConsoleColor.Green);

        }
        catch (Exception exc)
        {
            ConsoleHelper.WriteColored($"\n⛔ Error : {exc.Message}", ConsoleColor.DarkRed);
        }
    }

    public static double Logarithm(Func<double, double, double> operation)
    {
        double baseNum = ConsoleHelper.GetInput<double>("➡️ Enter the base : ");
        double argument = ConsoleHelper.GetInput<double>("➡️ Enter the argument : ");

        if (baseNum == 0 || baseNum < 0)
        {
            ConsoleHelper.WriteColored("\n❗ The base cannot be 0 or negative.", ConsoleColor.Red);
            return double.NaN;
        }
        if (baseNum == 1)
        {
            ConsoleHelper.WriteColored("\n❗ The base cannot be 1.", ConsoleColor.Red);
            return double.NaN;
        }
        if (argument < 0)
        {
            ConsoleHelper.WriteColored("\n❗ The argument cannot be 0 or negative.", ConsoleColor.Red);
            return double.NaN;
        }

        double result = operation(baseNum, argument);

        return ShowResult(result);
    }

    public static double ShowResult(double result)
    {
        ConsoleHelper.WriteColored($"\n✅ Result : {result}", ConsoleColor.Green);
        return result;
    }

}