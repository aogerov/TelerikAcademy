//Write a program that encodes and decodes a string using given encryption key (cipher). The key consists of a sequence of characters.
//The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key,
//the second – with the second, etc. When the last key character is reached, the next is the first.

using System;
using System.Text;

class EncodingDecoding
{
    static string EncodeDecode(string text, string cipher)
    {
        StringBuilder sb = new StringBuilder(text.Length);

        int cipherIndex = 0;

        for (int i = 0; i < text.Length; i++)
        {
            sb.Append((char)(text[i] ^ cipher[cipherIndex]));
            
            if (cipherIndex + 1 < cipher.Length)
            {
                cipherIndex++;
            }
            else
            {
                cipherIndex = 0;
            }
        }

        return sb.ToString();
    }

    static void Main()
    {
        Console.WriteLine("Enter some text for encoding:");
        //string text = Console.ReadLine();
        string text = "Write a program that encodes and decodes a string using given encryption key (cipher). The key consists of a sequence of characters." +
                    "The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key," +
                    "/the second – with the second, etc. When the last key character is reached, the next is the first.";

        Console.WriteLine("Enter cipher");
        //string cipher = Console.ReadLine();
        string cipher = "Secret";

        string encodedText = EncodeDecode(text, cipher);
        Console.WriteLine("Encoded text:\r\n{0}\r\n", encodedText);

        string decodedText = EncodeDecode(encodedText, cipher);
        Console.WriteLine("Decoded text:\r\n{0}\r\n", decodedText);
    }
}