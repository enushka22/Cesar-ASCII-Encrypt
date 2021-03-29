using System;

namespace CesarASCIIEncrypt
{
    class Program
    {
        static void Main(string[] args)
        {

            static string Caesar(string value, int shift)
            {
                char[] buffer = value.ToCharArray();
                for (int i = 0; i < buffer.Length; i++)
                {
                    // Letter.
                    char letter = buffer[i];
                    // Add shift to all.
                    letter = (char)(letter + shift);
                    // Subtract 26 on overflow.
                    // Add 26 on underflow.
                    if (letter > 'z')
                    {
                        letter = (char)(letter - 26);
                    }
                    else if (letter < 'a')
                    {
                        letter = (char)(letter + 26);
                    }
                    // Store.
                    buffer[i] = letter;
                }
                return new string(buffer);
            }


            string[] ascii_new = new string[94];

            int b = 0;

            for (int i = 32; i < 127; i++)
            {
                //char c = (char)i;
               // ascii_new[b] = c.ToString();
//Console.WriteLine(b + " - " + i + "- ascii -" + c.ToString());
               // b++;
            }


    


            string sentence = "lxxt>33m2mqkyv2gsq3q=w]O2ntk";
            //string sentence = "sq6wmgv2zcsrix6t.onion";
            
            char[] charArr = sentence.ToCharArray();

            char test;
            int sdvig = -4;
            foreach (char ch in charArr)
            {
                test = (char)(ch + sdvig);
                if (test > 127)
                {
                    test = (char)(test - 127);
                    Console.Write(test.ToString()); 
                }
                else if (test < 32) 
                {
                    test = (char)(test + 127);
                    Console.Write(test.ToString());
                }
                else 
                {
                    Console.Write(test.ToString());
                }



            }


        }
    }
}
