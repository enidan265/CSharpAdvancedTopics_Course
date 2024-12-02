namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string post = "This is supposed to be a very long blog post bla bla bla ...";
            var shortendPost = post.Shorten(5);
           
            Console.WriteLine(shortendPost);
        }
    }

}
