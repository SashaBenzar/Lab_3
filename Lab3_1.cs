using System;
using System.Linq;

namespace Lab3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int vibor=0;
            do //Зациклення програми
            {
                Console.Write("Введiть текст:");
                string txt = Console.ReadLine();
                string[] split1 = txt.Split(" ");
                int i = 0;
                Console.Write("1)Видаляє кожне друге слово: ");
                foreach (string s in split1) //Завдання а)
                {
                    if (s.Trim() != "")
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write(s + " ");
                        }
                        i++;
                    }
                }
                Console.Write("\n2)Знищує всi слова, якi починаються i закiнчуються за одну й ту ж лiтеру: ");
                foreach (string p in split1) //Завдання b)
                {
                    if (p.Trim() != "")
                    {
                        char[] word = p.ToCharArray();
                        if (!(word[0] == word[word.Length - 1]))
                        {
                            string a = new string(word);
                            Console.Write(a + " ");
                        }
                    }
                }
                Console.WriteLine("\n");
                int proverka = 0;
                do //Перевiрка
                {
                    Console.WriteLine(">>Натиснiть 1 якщо хочете повторити роботу програми");
                    Console.WriteLine(">>Натиснiть 2 якщо хочете закiнчити роботу програми");
                    Console.Write("Виберіть наступнi дiю:");
                    try
                    {
                        vibor = int.Parse(Console.ReadLine());
                        if (!(vibor == 1 || vibor==2)) //Введення iнших чисел
                        {
                            Console.WriteLine("Помилка! Такої команди немає, спробуйте ще раз\n");
                            proverka = 0;
                        }
                        else
                        {
                        proverka = 1;
                        Console.Write("\n");
                        }
                    }
                    catch (FormatException) //Неправильне значення
                    {
                        Console.WriteLine("Помилка! Неправильне значення, спробуйте ще раз\n");
                    }
                }while (proverka!=1);
            } while (vibor == 1);
        }
    }
}
