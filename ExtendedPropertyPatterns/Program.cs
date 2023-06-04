using System.Xml.Linq;
using ExtendedPropertyPatterns.Author;

Console.WriteLine(isHaveDiscountNew(new Book()).ToString());

bool isHaveDiscount(Book book) =>
book switch
{
    { Author: { Name: "Jeffrey Richter" } }
    or { Author: { Name: "David Flanagan" } } => true,
    _ => false
};

bool isHaveDiscountNew(Book book) =>
book switch
{
    { Author.Name: "Jeffrey Richter" }
    or { Author.Name: "David Flanagan" } => true,
    _ => false
};

public class Book
{
    public string Title { get; set; }
    public Author Author { get; set; }

    public Book()
    {
        Title = "CLR via C#";
        Author = new Author("Jeffrey Richter");
    }
}

