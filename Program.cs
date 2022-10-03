namespace Palindrome
{
    internal class Program
    {
        /**** FROM GEEKSFORGEEKS TUTORIAL https://www.geeksforgeeks.org/check-whether-the-given-string-is-palindrome-using-stack/  ****/
        char[] stack;
        int top = -1;

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

        // Function that returns 1 if string is a palindrome
        public int isPalindrome(char[] str)
        {
            int length = str.Length;

            // Allocate the memory for the stack
            stack = new char[length * 4];

            // Finding the midpoint
            int i, mid = length / 2;

            for (i = 0; i < mid; i++)
            {
                Push(str[i]);
            }

            // Checking if the length of the string is odd,
            // if odd then ignore the middle character
            if (length % 2 != 0)
            {
                i++;
            }

            // While not the end of the string
            while (i < length)
            {
                char element = Pop();

                // If the characters differ from the given string,
                // input is not a palindrome
                if (element != str[i])
                {
                    return 0;
                }

                i++;
            }

            return 1;
        }
        static void Main(string[] args)
        {

            char[] str = "madam".ToCharArray();

            if (isPalindrome(str) == 1)
            {
                Console.Write("Yes");
            }
            else
            {
                Console.Write("No");
            }




            /**** FROM PAVEL YOUTUBE TUTORIAL ****/
            //string input = "";
            //string inputBackward = "";
            //int index = 0;

            //Console.WriteLine("Please enter a word to determine whether it is a palindrome: ");
            //input = Console.ReadLine();

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
    }
}