namespace ReadFile
{
    internal class Program
    {
        const string FilePath = "../../../TextFile1.txt";

        static void Main(string[] args)
        {
            Console.WriteLine("Let's practice reading a file.");
            Console.WriteLine("Here are the contents of the file: ");
            Console.WriteLine(ReadFile(FilePath));
            Console.WriteLine();


        }

        static String ReadFile(String filename)
        {
            StreamReader sr = new(filename);
            return sr.ReadToEnd();
        }

        static void WriteFile(String filename, String contents)
        {
            StreamWriter sr = new(filename);
            sr.Write(contents);
            sr.Close();
        }
    }
}
