namespace Challenge3
{
    /*
     * Week 2, Challenge 3
     * Write a C# Sharp program that 
     * takes userid and password as input (type string). 
     * After 3 wrong attempts, user will be rejected.
     */
    internal class Program
    {
        private static Tuple<string, string> storedUserCredentials = new("SampleUser", "SamplePassword");

        static int Main(string[] args)
        {
            // Use numAttempts as a ref variable in GetUserInput()
            // to keep track of incorrect sign-in attempts
            int numAttempts = 0;

            // Store username and password together as a tuple
            Tuple<string, string> userCredentials = GetUserInput(ref numAttempts);

            // Continue prompting the user for creds if they are not validated
            // End the program with -1 return code if user's account gets locked
            while(!ValidatePassword(userCredentials))
            {
                Console.WriteLine("You entered an incorrect username or password.");
                if (numAttempts == 3)
                {
                    Console.WriteLine("Too many incorrect sign-in attempts. Your account has been locked.");
                    return -1;
                } 
                else
                {
                    userCredentials = GetUserInput(ref numAttempts);
                }
            }

            // If we reach this point, it must have been a successful sign-in
            Console.WriteLine($"\nWelcome, {storedUserCredentials.Item1}!\n");
            return 0;
        }

        static Tuple<string, string> GetUserInput(ref int numAttempts)
        {
            numAttempts++;
            Console.WriteLine("Enter your username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Enter your password: ");
            string password = Console.ReadLine();
            return new Tuple<string, string>(username, password);
        }

        static bool ValidatePassword(Tuple<string, string> userCredentials)
        {
            if (userCredentials.Equals(storedUserCredentials))
            {
                return true;
            }
            return false;
        }
    }
}
