namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var calculator = new Calculator();
                var result = calculator.Divide(5, 0);
            }
            catch(DivideByZeroException ex)
            {
                //Console.WriteLine("You cannot divide by 0.");
            }
            catch(ArithmeticException ex)
            {

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Sorry, an unexpected error occurred...");
            }

            //finally Block 

            StreamReader? streamReader = null; 
            try
            {
                streamReader = new StreamReader(@"C:\file.zip");
                var content = streamReader.ReadToEnd();
            }
            catch(Exception ex)
            {
                //Console.WriteLine("Sorry, an unexpected error occurred...");
                //Console.WriteLine(ex.Message);
            }
            finally
            {
                if(streamReader != null)
                {
                    streamReader.Dispose();
                }
            }

            // using

            try
            {
                using (streamReader = new StreamReader(@"C:\file.zip"))
                {
                    var content = streamReader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Sorry, an unexpected error occurred...");
                //Console.WriteLine(ex.Message);
            }

            // eigene Exceptions 

            try
            {
                var api = new YouTubeAPI();
                api.GetVideos("Nadine");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
