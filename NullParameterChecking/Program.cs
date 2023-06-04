
string book = null;

if (book == null)
{
    throw new ArgumentNullException(book);
}

ArgumentNullException.ThrowIfNull(book);

DateOnly date = new DateOnly(2021, 10, 9);