using System;
using System.Text;

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
                        //test = (char)(ch + shift - 127);
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

                        Console.Write("Выбетире сдвиг шифра от -127 до 127:");
                        sbyte sdvigshifra = Convert.ToSByte(Console.ReadLine());
                        
                        Console.WriteLine(EncryptCaesarASCII(origtext, sdvigshifra));
                        Console.ReadLine();
                        break;
                    }

                case "2":
                    {
                        Console.WriteLine("2You pressed x...");
                        break;
                    }

                default:
                    //string sentence = "lxxt>33m2mqkyv2gsq3q=w]O2ntk";
                    Console.WriteLine("Unknown Command.");
                    break;
            }











            


        }
    }
}
