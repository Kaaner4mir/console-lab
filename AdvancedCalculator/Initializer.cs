using System.Text;

class Initializer
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Title = "🧮 Advanced Calculator";

        try
        {
            while (true)
            {
                Console.Clear();
                Menu.MainMenu();
                short choice = ConsoleHelper.GetInput<short>("\n👉 Select the action you want to perform : ");
                Console.WriteLine();
                switch (choice)
                {
                    case 1: Elementary.Main("Addition", (val1, val2) => val1 + val2); break;
                    case 2: Elementary.Main("Subtraction", (val1, val2) => val1 - val2); break;
                    case 3: Elementary.Main("Multiplication", (val1, val2) => val1 * val2); break;
                    case 4: Elementary.Main("Division", (val1, val2) => val1 / val2); break;
                    case 5: Advanced.Exponentiation((baseNum, exponent) => Math.Pow(baseNum, exponent)); break;
                    case 6: Advanced.Root((radicand, degree) => Math.Pow(radicand, 1.0 / degree)); break;
                    case 7: Advanced.Factorial(); break;
                    case 8: Advanced.Modulo((dividend, divisior) => dividend % divisior); break;
                    case 9: Advanced.Logarithm((baseNum, argument) => Math.Log(argument, baseNum)); break;
                    case 10: Advanced.TrigonometryInitializer();break;
                    case 11: Memory.Initializer();break;
                    case 12:Environment.Exit(0);break;
                    default:ConsoleHelper.WriteColored("❓ The operation you want to perform could not be found.",ConsoleColor.Yellow);break;
                }
                ConsoleHelper.WaitingScreen();
            }
        }
        catch (Exception exc)
        {
            ConsoleHelper.WriteColored($"\n⛔ Error : {exc.Message}", ConsoleColor.DarkRed);
        }
    }
}