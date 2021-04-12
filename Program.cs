using System;
using System.Text;

namespace CesarASCIIEncrypt
{
    class Program
    {
        protected const string FIRST_CHOICE = "1";
        protected const string SECOND_CHOICE = "2";

        public static string EncryptCaesarASCII(string value, int shift)
        {
            char[] charArray = value.ToCharArray();
            char test;
            int i = 0;

            foreach (char item in charArray)
            {
                test = (char)(item + shift);

                if (test > 126)
                {
                    test = (char)(test - 127 + 32);
                }
                else if (test < 32)
                {
                    test = (char)(127 - (32 - test));
                }

                charArray[i] = test;
                i++;
            }

            return new string(String.Join("", charArray));

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //EncryptCaesarASCII("lxxt>33m2mqkyv2gsq3q=w]O2ntk", -4);
            Console.WriteLine("Программа для шифрования, расщифровки кода цезаря по таблице ASCII");
            Console.WriteLine("Задача:");
            Console.WriteLine("1. Шифровать (ENG)");
            Console.WriteLine("2. Расщифровать");
            Console.Write("Выбор: ");
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case FIRST_CHOICE:
                    {
                        Console.WriteLine("Введите текст для шифрования:");
                        string originalText = Console.ReadLine();

                        Console.Write("Выбетире сдвиг шифра от -95 до 95:");
                        sbyte shiftCount = Convert.ToSByte(Console.ReadLine());

                        if (shiftCount < -95 | shiftCount > 95) {
                            shiftCount = 0; 
                        }

                        Console.WriteLine(EncryptCaesarASCII(originalText, shiftCount));
                        Console.ReadLine();

                        break;
                    }
                case SECOND_CHOICE:
                    {
                        Console.WriteLine("Введите текст для расшифровки (ENG):");
                        string originalText = Console.ReadLine();

                        for (int i = 0; i < 95; i++) {
                            //Console.WriteLine("Value of i: {0}", i);
                            Console.WriteLine(i + " --- " + EncryptCaesarASCII(originalText, i));
                            Console.WriteLine();
                        }

                        Console.ReadLine();

                        break;
                    }
                default:
                    Console.WriteLine("Unknown Command.");
                    break;
            }
        }
    }
}
