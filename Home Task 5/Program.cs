using System;
using System.IO;
namespace Home_Task_5
{
    class Program
    {

        static void Main(string[] args)
        {
            // Задание 1. Ввести с клавиатуры произвольный набор данных и сохранить его в файл.

            Console.WriteLine("Привет! Введите случайный текст, а я запишу его в файл!");
            string text = Console.ReadLine();
            File.WriteAllText("File.txt", text);
            Console.WriteLine("Отлично, Ваш текст записан в файл с названием File.txt");
            Console.ReadLine();
            Console.Clear();

            //Задание 2. Написать программу, которая при старте дописывает текущее время в файл startup.txt.

            string Date = DateTime.Now.ToString("F");
            File.WriteAllText("startup.txt", Date);
            Console.WriteLine("Создан файл startup.txt с записью в него текущей даты");
            Console.ReadLine();
            Console.Clear();

            //Зажание 3. Ввести с клавиатуры произвольный набор чисел и записать их в бинарный файл.
            
            Console.WriteLine("Введите произвольный набор чисел от 0 до 255 через пробел для записи их в бинарный файл");
            string userinput = Console.ReadLine();
            string[] numb = userinput.Split(' ');
            byte[] numbers = new byte[numb.Length];

            for (int i = 0; i < numb.Length; i++)
            {
                numbers[i] = byte.Parse(numb[i]);
            }
           
            File.WriteAllBytes("Bytes.bin", numbers);
            Console.WriteLine("Введенные Вами числа записаны в файл Bytes.bin!");
            Console.ReadLine();
            Console.Clear();

            //Задание 4. Сохранить дерево каталогов и файлов по заданному пути в текстовый файл - с рекурсией и без.
            
            Console.WriteLine("Все папки и файлы Локального диска Е будут выведены на экран, а также записаны в файл Directory.txt!");
            string SampleDir = @"E:";
            Console.WriteLine(Directory.Exists(SampleDir));
            string[] AllDir = Directory.GetFileSystemEntries(SampleDir, "*", SearchOption.AllDirectories);
            
            for (int i = 0; i < AllDir.Length; i++)
            {
                Console.WriteLine(AllDir[i]); ;
            }

            File.AppendAllLines("Directory.txt", AllDir);
            Console.WriteLine("Все директории выведены на экран, файл Directory.txt\nс записанными в него всеми директориями локального диска Е успешно создан!");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
