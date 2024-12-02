

// LambdaExpression Syntax:

// arg => expression 
// argument goes to expression
//number => number*number


// kein Argument benötigt
// () => ....

// ein Argument benötigt
// x => ....

// mehrere Argumente benötigt
// (x, y, z) => ....

// Basics:
// ###########

//Zugriff auf Variablen 
using LambdaExpressions;
using System.Buffers.Binary;

const int factor = 5; 

Func<int, int> multiplier = num => num * factor;

//Console.WriteLine(multiplier(2));


// mit LambaExpressions

Func<int, int> square = number => number*number;

//Console.WriteLine("Mit Lambda-Expression: "+ square(5));


// ohne LambdaExpressions

//Console.WriteLine("Ohne Lambda-Expression: " + Square(5));

// Methode, die eine Nummer entgegen nimmt und das Quadrat der Nummer zurückgibt 
static int Square(int number)
{
    return number*number; 
}



// Beispiel: 
// Funktion, die alle Bücher ausgibt, die wenger als 10€ kosten

// ohne LambdaExpression

var books = new BookRepository().GetBooks();

var cheapbooks2 = books.FindAll(IsCheaperThan10Euros);

foreach (var book in cheapbooks2)
{
    Console.WriteLine($"{book.Title} - {book.Price} EUR ");
}

static bool IsCheaperThan10Euros(Book book)
{
    return book.Price < 10;
}


// mit LambdaExpression

var cheapbooks = books.FindAll(b => b.Price < 10);

foreach (var book in cheapbooks)
{
    Console.WriteLine($"{book.Title} - {book.Price} EUR ");
}