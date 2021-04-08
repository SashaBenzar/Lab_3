using System;
using System.IO;

namespace Lab3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader txt1 = new StreamReader("C:\\Users\\Alex\\Desktop\\Tests\\Lab3_2\\txt1.txt");
            StreamReader txt2 = new StreamReader("C:\\Users\\Alex\\Desktop\\Tests\\Lab3_2\\txt2.txt");
            StreamWriter f = new StreamWriter("C:\\Users\\Alex\\Desktop\\Tests\\Lab3_2\\txt3.txt");
            string text1 = txt1.ReadLine(), text2 = txt2.ReadLine();
            string[] split1 = text1.Split(" ");
            string[] split2 = text2.Split(" ");
            for (int i=0; i<split2.Length; i++) //Запис у третій файл по черзі значення з файлу 1 i 2
            {
                f.Write(split1[i]+";"+split2[i]+";");
            }
            f.Close();
        }
    }
}
