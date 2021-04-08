using System;
using System.IO;

namespace Lab3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader txt1 = new StreamReader("C:\\Users\\Alex\\Desktop\\Tests\\Lab3_3\\input.txt");
            StreamWriter f = new StreamWriter("C:\\Users\\Alex\\Desktop\\Tests\\Lab3_3\\output.txt");
            string txt = txt1.ReadLine();
            string[] split1 = txt.Split(" ");
            string max = split1[0];
            foreach (string p in split1) //виводить на екран найдовше слово
            {
                if (p.Length>max.Length)
                {
                    max = p;
                }
            }
            f.Write(max);
            f.Close();
        }
    }
}
