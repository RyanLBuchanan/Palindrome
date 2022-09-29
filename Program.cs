namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            string inputBackward = "";
            int index = 0;

            Console.WriteLine("Please enter a word to determine whether it is a palindrome: ");
            input = Console.ReadLine();

            //while (input.Length > 5)
            //{
            //    Console.WriteLine("The word must be no more than 5 letters. Try again: ");
            //    input = Console.ReadLine();
            //}

            index = input.Length - 1;

            while (index >= 0)
            {
                
                inputBackward += input.Substring(index, 1);
                index--;
            }

            if (input == inputBackward)
            {
                Console.WriteLine("The word you entered is a palindrome.");
            }
            else
            {
                Console.WriteLine($"The word {input} is NOT a palindrome.");
            }

            Console.ReadLine();
        }
    }
}