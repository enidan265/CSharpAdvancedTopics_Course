
using Generics;
using Generics.Models;

//var book = new Book { Isbn = "12345", Title = "Carrie" };

//// ohne Generics -> zwei unterschiedliche Klassen benötigt 
//var numbers = new List();
//numbers.Add(10);

//var books = new BookList();
//books.Add(book);

//// mit Generics -> gleiche Klasse für beide Listen verwendbar 
//var numbersGen = new GenericList<int>();
//numbersGen.Add(10);

//var booksGen = new GenericList<Book>();
//booksGen.Add(book);

//// Generic-Dictionary 
//var dictionaryGen = new GenericDictionary<string, Book>();
//dictionaryGen.Add("1234", book);


// Contraint to Valuetype - Nullable Valuetype

var num = new Generics.Nullable<int>();
Console.WriteLine($"Has Value ? {num.HasValue}");
Console.WriteLine($"Value: {num.GetValueOrDefault()}");