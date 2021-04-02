using System;

namespace CesarASCIIEncrypt
{
    class Program
    {
        static void Main(string[] args)
        {

            static string EncryptCaesarASCII(string value, int shift)
            {
                char[] charArr = value.ToCharArray();
                char test;
                int i = 0;

                foreach (char ch in charArr)
                {              
                    test = (char)(ch + shift);

                    if (test > 126)
                    {
                        test = (char)(test - 127 + 32);
                        //Console.Write(test.ToString());
                    }
                    else if (test < 32)
                    {
                        test = (char)(127 - (32 - test));
                        //Console.Write(test.ToString());
                    }
                    else
                    {
                        //Console.Write(test.ToString());
                    }

                    charArr[i] = test;
                    i++;
                }              
                return new string(String.Join("", charArr));
                
            }



            //EncryptCaesarASCII("lxxt>33m2mqkyv2gsq3q=w]O2ntk", -4);
            Console.WriteLine("Программа для шифрования, расщифровки кода цезаря по таблице ASCII");
            Console.WriteLine("Задача:");
            Console.WriteLine("1. Шифровать (ENG)");
            Console.WriteLine("2. Расщифровать");
            Console.Write("Выбор: ");
            string vibor = Console.ReadLine();



            switch (vibor)
            {
                case "1":
                    {
                        Console.WriteLine("Введите текст для шифрования:");
                        string origtext = Console.ReadLine();

                        Console.Write("Выбетире сдвиг шифра от -95 до 95:");
                        sbyte sdvigshifra = Convert.ToSByte(Console.ReadLine());

                        if (sdvigshifra < -95 | sdvigshifra > 95) 
                        { 
                            sdvigshifra = 0; 
                        }

                        Console.WriteLine(EncryptCaesarASCII(origtext, sdvigshifra));
                        Console.ReadLine();
                        break;
                    }

                case "2":
                    {
                        Console.WriteLine("Введите текст для расшифровки (ENG):");
                        string origtext = Console.ReadLine();

                        for (int i = 0; i < 95; i++)
                        {
                            //Console.WriteLine("Value of i: {0}", i);
                            Console.WriteLine(i +" --- " + EncryptCaesarASCII(origtext, i));
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
