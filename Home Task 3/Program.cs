using System;

namespace Home_Task_3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Задание 1: Написать программу, выводящую элементы массива по диагонали.

            Console.WriteLine("Вывод элементов случайного двухмерного массива:");
            int[,] array = new int[4, 4];
            Random RanNumber = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = RanNumber.Next(100);
                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            Console.WriteLine("Вывод элементов двухмерного массива находящихся по диагонали:");
            Console.Write($"{array[0, 0]} {array[1, 1]} {array[2, 2]} {array[3, 3]}");
            Console.ReadLine();
            Console.Clear();

            //Задание 2. Телефонный справочник.
            Console.WriteLine("Телефонный справочник сотрудников организации:");
            string[,] TeleList = new string[,]
            {
                {"Иванов", "153-71"},
                {"Петров", "petrov@company.ru"},
                {"Сидоров", "164-18"},
                {"Исупов", "isupov@company.ru"},
                {"Сенин", "+79649874532"}
            };

            for (int i = 0; i < TeleList.GetLength(0); i++)
            {
                for (int j = 0; j < TeleList.GetLength(1); j++)
                {
                    Console.Write(TeleList[i, j] + "\t");
                }
                Console.WriteLine();

            }
            Console.ReadLine();
            Console.Clear();

            //Задание 3. Программа по выводу введенных данных в обратном порядке. // метод перевода введенной фразы в массив символов, подсмотрел в docs.microsoft.com
            Console.WriteLine("Введите Слово или фразу, а я выведу её в обратном порядке:");
            string phrase = Console.ReadLine();
            char[] phraseReverse = phrase.ToCharArray();
            Array.Reverse(phraseReverse);
            phrase = new string(phraseReverse);
            Console.WriteLine(phrase);
            Console.ReadLine();
            Console.Clear();

            //Задание 4. Вывести в консоли массив "Морской бой".

            string[,] WaterFight = new string[,]
            {
                {"O","O","O","O","O","O","O","O","O","O"},
                {"O","X","O","O","O","O","O","O","X","O"},
                {"O","O","O","O","X","O","O","O","O","O"},
                {"O","O","O","O","X","O","O","X","O","O"},
                {"O","X","O","O","X","O","O","X","O","X"},
                {"O","X","O","O","X","O","O","X","O","X"},
                {"O","O","O","O","O","O","O","O","O","O"},
                {"O","O","O","X","X","X","O","O","O","O"},
                {"O","X","O","O","O","O","O","O","X","O"},
                {"O","O","O","O","X","X","O","O","O","O"}
            };

            for (int i = 0; i < WaterFight.GetLength(0); i++)
            {
                for (int j = 0; j < WaterFight.GetLength(1); j++)
                {
                    Console.Write(WaterFight[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            Console.Clear();
        }

    }
             
}