class DataStore
{
    static List<Book> _books = new List<Book>
        {
          new Book { BookId = Random.Shared.Next(100000,999999), BookName = "The Great Gatsby", Author = "F. Scott Fitzgerald", Publisher = "Scribner", PublicationYear = "1925", Genre = "Novel", Language = "English", PageCount = "218" },
          new Book { BookId = Random.Shared.Next(100000,999999), BookName = "To Kill a Mockingbird", Author = "Harper Lee", Publisher = "J.B. Lippincott & Co.", PublicationYear = "1960", Genre = "Novel", Language = "English", PageCount = "336" },
          new Book { BookId = Random.Shared.Next(100000,999999), BookName = "The Catcher in the Rye", Author = "J.D. Salinger", Publisher = "Little, Brown and Company", PublicationYear = "1951", Genre = "Novel", Language = "English", PageCount = "277" },
          new Book { BookId = Random.Shared.Next(100000,999999), BookName = "Brave New World", Author = "Aldous Huxley", Publisher = "Chatto & Windus", PublicationYear = "1932", Genre = "Dystopian", Language = "English", PageCount = "311" },
          new Book { BookId = Random.Shared.Next(100000,999999), BookName = "Lord of the Flies", Author = "William Golding", Publisher = "Faber and Faber", PublicationYear = "1954", Genre = "Novel", Language = "English", PageCount = "224" },
          new Book { BookId = Random.Shared.Next(100000,999999), BookName = "The Hobbit", Author = "J.R.R. Tolkien", Publisher = "George Allen & Unwin", PublicationYear = "1937", Genre = "Fantasy", Language = "English", PageCount = "310" },
          new Book { BookId = Random.Shared.Next(100000,999999), BookName = "Animal Farm", Author = "George Orwell", Publisher = "Secker & Warburg", PublicationYear = "1945", Genre = "Political Satire", Language = "English", PageCount = "112" },
          new Book { BookId = Random.Shared.Next(100000,999999), BookName = "Of Mice and Men", Author = "John Steinbeck", Publisher = "Covici Friede", PublicationYear = "1937", Genre = "Novella", Language = "English", PageCount = "107" },
          new Book { BookId = Random.Shared.Next(100000,999999), BookName = "Pride and Prejudice", Author = "Jane Austen", Publisher = "T. Egerton", PublicationYear = "1813", Genre = "Novel", Language = "English", PageCount = "432" },
          new Book { BookId = Random.Shared.Next(100000,999999), BookName = "The Old Man and the Sea", Author = "Ernest Hemingway", Publisher = "Charles Scribner's Sons", PublicationYear = "1952", Genre = "Novel", Language = "English", PageCount = "127" },
          new Book { BookId = Random.Shared.Next(100000,999999), BookName = "The Picture of Dorian Gray", Author = "Oscar Wilde", Publisher = "Ward, Lock & Co.", PublicationYear = "1890", Genre = "Novel", Language = "English", PageCount = "254" },
          new Book { BookId = Random.Shared.Next(100000,999999), BookName = "Frankenstein", Author = "Mary Shelley", Publisher = "Lackington, Hughes, Harding, Mavor & Jones", PublicationYear = "1818", Genre = "Gothic", Language = "English", PageCount = "280" },
          new Book { BookId = Random.Shared.Next(100000,999999), BookName = "Moby-Dick", Author = "Herman Melville", Publisher = "Harper & Brothers", PublicationYear = "1851", Genre = "Adventure", Language = "English", PageCount = "635" },
          new Book { BookId = Random.Shared.Next(100000,999999), BookName = "Great Expectations", Author = "Charles Dickens", Publisher = "Chapman & Hall", PublicationYear = "1861", Genre = "Novel", Language = "English", PageCount = "505" },
          new Book { BookId = Random.Shared.Next(100000,999999), BookName = "Jane Eyre", Author = "Charlotte Brontë", Publisher = "Smith, Elder & Co.", PublicationYear = "1847", Genre = "Novel", Language = "English", PageCount = "500" },
          new Book { BookId = Random.Shared.Next(100000,999999), BookName = "Wuthering Heights", Author = "Emily Brontë", Publisher = "Thomas Cautley Newby", PublicationYear = "1847", Genre = "Novel", Language = "English", PageCount = "416" },
          new Book { BookId = Random.Shared.Next(100000,999999), BookName = "Dracula", Author = "Bram Stoker", Publisher = "Archibald Constable and Company", PublicationYear = "1897", Genre = "Horror", Language = "English", PageCount = "418" },
          new Book { BookId = Random.Shared.Next(100000,999999), BookName = "The Grapes of Wrath", Author = "John Steinbeck", Publisher = "Viking Press", PublicationYear = "1939", Genre = "Novel", Language = "English", PageCount = "464" },
          new Book { BookId = Random.Shared.Next(100000,999999), BookName = "Slaughterhouse-Five", Author = "Kurt Vonnegut", Publisher = "Delacorte", PublicationYear = "1969", Genre = "Science Fiction", Language = "English", PageCount = "275" },
          new Book { BookId = Random.Shared.Next(100000,999999), BookName = "Fahrenheit 451", Author = "Ray Bradbury", Publisher = "Ballantine Books", PublicationYear = "1953", Genre = "Dystopian", Language = "English", PageCount = "194" },
          new Book { BookId = Random.Shared.Next(100000,999999), BookName = "The Lord of the Rings", Author = "J.R.R. Tolkien", Publisher = "George Allen & Unwin", PublicationYear = "1954", Genre = "Fantasy", Language = "English", PageCount = "1216" },
          new Book { BookId = Random.Shared.Next(100000,999999), BookName = "Harry Potter and the Philosopher's Stone", Author = "J.K. Rowling", Publisher = "Bloomsbury", PublicationYear = "1997", Genre = "Fantasy", Language = "English", PageCount = "223" },
          new Book { BookId = Random.Shared.Next(100000,999999), BookName = "The Chronicles of Narnia", Author = "C.S. Lewis", Publisher = "Geoffrey Bles", PublicationYear = "1950", Genre = "Fantasy", Language = "English", PageCount = "767" },
          new Book { BookId = Random.Shared.Next(100000,999999), BookName = "The Adventures of Sherlock Holmes", Author = "Arthur Conan Doyle", Publisher = "George Newnes", PublicationYear = "1892", Genre = "Detective", Language = "English", PageCount = "307" },
          new Book { BookId = Random.Shared.Next(100000,999999), BookName = "The Odyssey", Author = "Homer", Publisher = "Penguin Classics", PublicationYear = "800 BC", Genre = "Epic", Language = "English", PageCount = "541" },
          new Book { BookId = Random.Shared.Next(100000,999999), BookName = "The Iliad", Author = "Homer", Publisher = "Penguin Classics", PublicationYear = "762 BC", Genre = "Epic", Language = "English", PageCount = "704" },
          new Book { BookId = Random.Shared.Next(100000,999999), BookName = "Crime and Punishment", Author = "Fyodor Dostoyevsky", Publisher = "Penguin Classics", PublicationYear = "1866", Genre = "Novel", Language = "English", PageCount = "671" },
          new Book { BookId = Random.Shared.Next(100000,999999), BookName = "Alice's Adventures in Wonderland", Author = "Lewis Carroll", Publisher = "Macmillan", PublicationYear = "1865", Genre = "Fantasy", Language = "English", PageCount = "201" },
          new Book { BookId = Random.Shared.Next(100000,999999), BookName = "The Call of the Wild", Author = "Jack London", Publisher = "Macmillan", PublicationYear = "1903", Genre = "Adventure", Language = "English", PageCount = "232" },
          new Book { BookId = Random.Shared.Next(100000,999999), BookName = "The Secret Garden", Author = "Frances Hodgson Burnett", Publisher = "Frederick A. Stokes", PublicationYear = "1911", Genre = "Children's", Language = "English", PageCount = "331" },
          new Book { BookId = Random.Shared.Next(100000,999999), BookName = "Anne of Green Gables", Author = "L.M. Montgomery", Publisher = "L.C. Page & Co.", PublicationYear = "1908", Genre = "Children's", Language = "English", PageCount = "320" },
          new Book { BookId = Random.Shared.Next(100000,999999), BookName = "Peter Pan", Author = "J.M. Barrie", Publisher = "Hodder & Stoughton", PublicationYear = "1911", Genre = "Fantasy", Language = "English", PageCount = "223" }
        };

    public static void List()
    {
        Console.WriteLine("\x1b[2J");

        foreach (var item in _books)
        {
            ConsoleHelper.WriteColored($"🔑 Book ID        : {item.BookId}", ConsoleColor.Yellow);
            ConsoleHelper.WriteColored($"🏷️ Book Name      : {item.BookName}", ConsoleColor.Cyan);
            ConsoleHelper.WriteColored($"👤 Author         : {item.Author}", ConsoleColor.Magenta);
            ConsoleHelper.WriteColored($"🌆 Publisher      : {item.Publisher}", ConsoleColor.DarkCyan);
            ConsoleHelper.WriteColored($"📅 Publisher Year : {item.PublicationYear}", ConsoleColor.DarkYellow);
            ConsoleHelper.WriteColored($"🎭 Genre          : {item.Genre}", ConsoleColor.Green);
            ConsoleHelper.WriteColored($"🌐 Language       : {item.Language}", ConsoleColor.DarkMagenta);
            ConsoleHelper.WriteColored($"📆 Page Count     : {item.PageCount}", ConsoleColor.DarkGray);

            ConsoleHelper.WriteColored(new string('-', 50), ConsoleColor.Gray);
        }
    }
}
