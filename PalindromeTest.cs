namespace Palindrome
{
    internal class PalindromeTest
    {
        /**** FROM GEEKSFORGEEKS TUTORIAL https://www.geeksforgeeks.org/check-whether-the-given-string-is-palindrome-using-stack/  ****/


        static char[] stack;
        static int top = -1;

        // Push function
        static void Push(char element)
        {
            stack[++top] = element;
        }

        // Pop function
        static char Pop()
        {
            return stack[top--];
        }

        // Function that returns 1
        // if str is a palindrome
        static int isPalindrome(char[] inputWord)
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

        // Driver code
        public static void Main(String[] args)
        {
            //char[] inputWord = "tacocat".ToCharArray();

            Console.WriteLine("Please enter a word to determine whether it is a palindrome: ");
            char[] inputWord = Console.ReadLine();

            if (isPalindrome(inputWord) == 1)
            {
                Console.Write("Yes");
            }
            else
            {
                Console.Write("No");
            }
        }
    }





    /**** FROM PAVEL YOUTUBE TUTORIAL ****/
    //string input = "";
    //string inputBackward = "";
    //int index = 0;



    //while (input.Length > 10)
    //{
    //    Console.WriteLine("The word must be no more than 5 letters. Try again: ");
    //    input = Console.ReadLine();
    //}

    //// Update index following user input
    //index = input.Length - 1;

    //while (index >= 0)
    //{

    //    inputBackward += input.Substring(index, 1);
    //    index--;
    //}

    //if (input == inputBackward)
    //{
    //    Console.WriteLine("The word you entered is a palindrome.");
    //}
    //else
    //{
    //    Console.WriteLine($"The word {input} is NOT a palindrome.");
    //}

    //Console.ReadLine();
}