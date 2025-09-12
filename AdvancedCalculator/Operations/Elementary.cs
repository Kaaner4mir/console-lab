class Elementary
{
    public static double Main(string operationName, Func<double, double, double> operation)
    {
        try
        {
            double val1 = ConsoleHelper.GetInput<double>("➡️ Enter the first number : ");
            double val2 = ConsoleHelper.GetInput<double>("➡️ Enter the second number : ");

            if (operationName.ToLower() == "division" && val1 == 0 && val2 == 0)
            {
                ConsoleHelper.WriteColored("\n❓ Undefined!", ConsoleColor.Red);
                return double.NaN;
            }
            if (operationName.ToLower() == "division" && val2 == 0)
            {
                ConsoleHelper.WriteColored("\n❗ Divisior cannot be 0!", ConsoleColor.Red);
                return double.NaN;
            }

            double result = operation(val1, val2);

            return ShowResult(result);
        }
        catch (Exception exc)
        {
            ConsoleHelper.WriteColored($"\n⛔ Error : {exc.Message}", ConsoleColor.DarkRed);
            return double.NaN;
        }
    }
    public static double ShowResult(double result)
    {
        ConsoleHelper.WriteColored($"\n✅ Result : {result}", ConsoleColor.Green);
        return result;
    }

}