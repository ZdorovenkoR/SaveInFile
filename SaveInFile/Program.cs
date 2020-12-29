using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл..

namespace SaveInFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите данные");
            string userData = Console.ReadLine();
            StreamWriter userData2 = new StreamWriter("test.txt", true); ;
            userData2.WriteLine(userData);
            userData2.Close();
            Console.WriteLine("Данные сохранены");
        }
    }
}
