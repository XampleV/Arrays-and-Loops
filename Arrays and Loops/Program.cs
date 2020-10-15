using System;

namespace Arrays_and_Loops
{
    class Program
    {
        public static char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        public static char[] secretMessage;
        public static char[] encryptedMessage;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a message to encrypt:");
            string userInput = Console.ReadLine();
            secretMessage = userInput.ToCharArray();
            encryptedMessage = new char[secretMessage.Length];
            Console.WriteLine(Encrypt());
        }
        static string Encrypt()
        {
            int i;
            for (i = 0; i < secretMessage.Length; i++)
            {
                char tempVal = secretMessage[i];
                int index = Array.IndexOf(alphabet, tempVal) + 3;
                char letter = alphabet[index % alphabet.Length];

                encryptedMessage[i] = letter;
            }
            return String.Join("", encryptedMessage);


        }
    }
}
