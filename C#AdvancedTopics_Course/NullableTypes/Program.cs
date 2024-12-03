namespace NullableTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime? date = null;
            DateTime date2 = date ?? DateTime.Today;

            Console.WriteLine(date2);

        }
    }
}
