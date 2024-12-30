namespace Palindrome_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool checkAgain = true;
            while (checkAgain)
            {
                Console.WriteLine("Enter a word for check: ");
                string word = Console.ReadLine().ToLower().Trim();

                if (string.IsNullOrEmpty(word))
                {
                    Console.WriteLine("Invalid input! Please enter a non-empty word.");
                    return;
                }

                char[] charArray = word.ToCharArray();
                Array.Reverse(charArray);
                string reversedWord = new string(charArray);

                if (word == reversedWord)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("It's a palindrome!");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("It's not a palindrome.");
                    Console.ResetColor();
                }
                Console.WriteLine("Wanna check another word? (Y/N)");
                string answer = Console.ReadLine().ToLower();

                if (answer == "y")
                {
                    Console.Clear();
                    continue;
                }
                else if (answer == "n")
                {
                    Console.WriteLine("Exiting program..");
                    Thread.Sleep(2000);
                    checkAgain = false;

                }
                else
                {
                    Console.WriteLine("Invalid choice. Exiting program..");
                    checkAgain = false;
                }

            }
        }
    }
}
