using System;
namespace ExtensionMethods
{
    public class Books
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return string.Format("Title: {0}, \nAuthor: {1}, \nPrice: {2}",
                this.Title,
                this.Author,
                this.Price);
        }
    }

    public class BookRepository
    {
        private List<Books> _listOfBooks = new List<Books>() {
            new Books()
            {
                Author = "Shashi",
                Title = "This World",
                Price = 11.22
            },
            new Books()
            {
                Author = "Bhushan",
                Title = "Old World",
                Price = 22.99
            },
            new Books()
            {
                Author = "Shashi",
                Title = "New World",
                Price = 199.99
            },
            new Books()
            {
                Author = "Shashi",
                Title = "Moh World",
                Price = 98.99
            }
        };

        public List<Books> GetBooks()
        {
            return this._listOfBooks;
        }
    }
}

