namespace Palindrome
{
    internal class PalindromeTest
    {
        public static void Main(String[] args)
        {
            /**** FROM GEEKSFORGEEKS TUTORIAL https://www.geeksforgeeks.org/check-whether-the-given-string-is-palindrome-using-stack/  ****/
            char[] stack;
            int top = -1;
            string inputWord = "";

            // Header
            Console.WriteLine("----------Palindrome Test----------\n");


            while (inputWord != "-1")
            {
                Console.WriteLine("Please enter a word to test palindromicity (enter -1 to quit): ");

                inputWord = Console.ReadLine();

                char[] wordToTest = inputWord.ToLower().Replace(" ", "").ToCharArray();
                if (inputWord == "-1")
                {
                    return;
                }

                if (isPalindrome(wordToTest) == 1)
                {
                    Console.WriteLine($"The word {inputWord} is a palindrome.");
                }
                else
                {
                    Console.WriteLine($"The word {inputWord} is NOT a palindrome.");
                }
                Console.WriteLine();
            }

            // Push function
            void Push(char element)
            {
                stack[++top] = element;
            }

            // Pop function
            char Pop()
            {
                return stack[top--];
            }

            // Function that returns 1
            // if str is a palindrome
            int isPalindrome(char[] inputWord)
            {
                int length = inputWord.Length;

                // Allocating the memory for the stack
                stack = new char[length * 4];

                // Finding the mid
                int i, mid = length / 2;

                for (i = 0; i < mid; i++)
                {
                    Push(inputWord[i]);
                }

                // Checking if the length of the String
                // is odd, if odd then neglect the
                // middle character
                if (length % 2 != 0)
                {
                    i++;
                }

                // While not the end of the String
                while (i < length)
                {
                    char element = Pop();

                    // If the characters differ then the
                    // given String is not a palindrome
                    if (element != inputWord[i])
                        return 0;
                    i++;
                }
                return 1;
            }
        }
    }
}