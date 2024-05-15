namespace Assignment2._3._1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                string FilePath = @"C:\Test\Sample.txt";
                using (var myFile = new StreamWriter(FilePath))
                {
                    myFile.WriteLine("First Name: John");
                    myFile.WriteLine("Last Name: Doe");
                    myFile.WriteLine("Age: 30");
                    myFile.WriteLine("Address: 42 Wallaby Way, Sydney");
                }

                Console.WriteLine("Here are the contents of Sample.txt: ");
                Console.WriteLine(File.ReadAllText(FilePath));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong: \n" + ex.Message);
            }
            
        }
    }
}
