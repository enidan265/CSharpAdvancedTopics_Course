namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            // Alle Bücher ausgeben, die weniger als 10 EUR kosten
            
            // ohne LINQ

            var cheapBooks = new List<Book>();
            foreach(var book in books)
            {
                if(book.Price < 10)
                {
                    cheapBooks.Add(book);
                }
            }

            //Console.WriteLine("Ausgabe ohne LINQ:");
            foreach (var book in cheapBooks)
            {
                //Console.WriteLine(book.Title + " " + book.Price);
            }
            Console.WriteLine();


            // mit LINQ

            var cheapBooks2 = books
                                .Where(b => b.Price < 10)
                                .OrderBy(b => b.Title)
                                .Select(b => b.Title);

            var cheapBooks3 = books.Select(b => b.Title);

            var oneBook = books.Single(b => b.Title == "ASP.NET MVC");

            var firstBook = books.First(b => b.Title == "C# Advanced Topics");

            var skipBooks = books.Skip(2);

            var skipTakeBooks = books.Skip(2).Take(4);

            var maxPrice = books.Max(b => b.Price);
            var minPrice = books.Min(b => b.Price);
            var totalPrice = books.Sum(b => b.Price);
            var avgPrice = books.Average(b => b.Price);

           
            Console.WriteLine(maxPrice);
            Console.WriteLine(minPrice);
            Console.WriteLine(totalPrice);
            Console.WriteLine(avgPrice);


            //Console.WriteLine("Ausgabe mit LINQ: ");
            foreach (var book in skipTakeBooks)
            {
                //Console.WriteLine(book);
                Console.WriteLine(book.Title + " " + book.Price);
            }


        }

        // Selector
        public static string BookTitleSelector(Book book)
        {
            return book.Title;
        }
    }
}
