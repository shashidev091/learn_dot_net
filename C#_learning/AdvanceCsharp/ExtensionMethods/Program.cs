using ExtensionMethods;

string post = "This is a must have test value to test you string value";

Console.WriteLine(post.Shorten(10));

var bookRepo = new BookRepository();
var books = bookRepo.GetBooks();

var shashiBooks = books.Where((book) => book.Author == "Shashi");

foreach (var book in shashiBooks)
    Console.WriteLine(book.Author);


var cheapBooks = books
    .Where(book => book.Price > 30)
    .OrderBy(book => book.Price); 

foreach(var b in cheapBooks)
    Console.WriteLine(b.Price);


var book_ = books.SingleOrDefault(book => book.Title == "Old World");
Console.WriteLine(book_);

var bookSkipped = books.Skip(3);

foreach(var book in bookSkipped)
    Console.WriteLine(book);

var maxBooks = books.Max(b => b.Price);
Console.WriteLine(maxBooks);

