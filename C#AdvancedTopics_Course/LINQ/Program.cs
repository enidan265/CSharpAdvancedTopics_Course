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



            Console.WriteLine(oneBook.Title);





            //Console.WriteLine("Ausgabe mit LINQ: ");
            foreach (var book in cheapBooks2)
            {
                //Console.WriteLine(book);
                //Console.WriteLine(book.Title + " " + book.Price);
            }


        }

        // Selector
        public static string BookTitleSelector(Book book)
        {
            return book.Title;
        }
    }
}
