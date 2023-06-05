
Console.WriteLine("C#9 Объявления верхнего уровня!");

/*namespace FileScopedNamespaceDeclaration
{
    using System.Xml.Linq;
    using ExtendedPropertyPatterns.Author;

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(Book.isHaveDiscount(new Book()).ToString());
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public Author Author { get; set; }

        public Book(string title, Author author) =>
            (Title, Author) = (title, author);

        public Book()
        {
            Title = "CLR via C#";
            Author = new Author("Jeffrey Richter");
        }

        public static bool isHaveDiscount(Book book) =>
        book switch
        {
            { Author: { Name: "Jeffrey Richter" } }
            or { Author: { Name: "David Flanagan" } } => true,
            _ => false
        };
    }
}*/