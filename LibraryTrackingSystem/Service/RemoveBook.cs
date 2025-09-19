class RemoveBook
{
    public static void Remove()
    {
        Console.Clear();
        DataStore.List();

        int id = ConsoleHelper.GetInput<int>("\n🪪 Enter the ID of the book you want to remove : ");

        var account = DataStore.ExampleBooks().FirstOrDefault(x => x.BookId == id);

        if (account == null)
        {
            ConsoleHelper.WriteColored("\n❓ The book could not be found.", ConsoleColor.Yellow);
            return;
        }

        DataStore.ExampleBooks().Remove(account);

        ConsoleHelper.WriteColored("\n✅ Book removed successfully.", ConsoleColor.Green);
    }
}
