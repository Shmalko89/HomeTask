using System;

namespace HomeTask_4
{
    class Program
    {


        public enum seasons
        {
            spring,
            summer,
            autumn,
            winter
        }


        static void GetFullNameList()
        {
            Console.WriteLine("Иванов Иван Иванович" + "\n" + "Дмитриев Дмитрий Дмитриевич" + "\n" + "Петров Петр Петрович");

        }
        static string GetFullName()
        {
            Console.WriteLine("Введите имя:");
            string firstname = Console.ReadLine();
            Console.WriteLine("Введите отчество:");
            string Midlename = Console.ReadLine();
            Console.WriteLine("Введите фамилию:");
            string Secondname = Console.ReadLine();
            string FullName = Secondname + " " + firstname + " " + Midlename;
            return FullName;
        }
        static int GetSumString()
        {
            string UserAnswer = Console.ReadLine();
            string[] letters = UserAnswer.Split(' ');
            int[] numbers = new int[letters.Length];
            int SumNumbers = 0;

            for (int i = 0; i < letters.Length; i++)
            {
                int number;
                if (int.TryParse(letters[i], out number))
                {
                    numbers[i] = number;
                    SumNumbers = SumNumbers + numbers[i];
                }
                else
                {
                    Console.WriteLine("Введите цифры а не символы!");
                }

            }
                 return SumNumbers;
            
        }
        static seasons GuesSeason()
        {
            int Answer = int.Parse(Console.ReadLine());
            if (Answer == 1 || Answer == 2 || Answer == 12 && 1 <= Answer && Answer <= 12)
            {
                return seasons.winter;
            }
            else if (Answer == 3 || Answer == 4 || Answer == 5 && 1 <= Answer && Answer <= 12)
            {
                return seasons.spring;
            }
            else if (Answer == 6 || Answer == 7 || Answer == 8 && 1 <= Answer && Answer <= 12)
            {
                return seasons.summer;
            }
            else if (Answer == 9 || Answer == 10 || Answer == 11 && 1 <= Answer && Answer <= 12)
            {
                return seasons.autumn;
            }
            else if (0 < Answer || Answer > 12)
            {
                Console.WriteLine("Вы ввели некоректное число, нужно от 1 до 12!");
            }
            return seasons.winter;
        }
        static string RusSeason(string b)
        {
            
            if (b == "spring")
            {
                return "Весна";
            }
            else if (b == "summer")
            {
                return "Лето";
            }
            else if (b == "autumn")
            {
                return "Осень";
            }
            else if (b == "winter")
            {
                return "Зима";
            }
            return b;
        }

        static ulong Fibonachi(int c)
        {

            if (c == 0 || c== 1)       
                return 1;
            else
                return Fibonachi(c - 2) + Fibonachi(c - 1);
           
        }
        static void Main(string[] args)
        {
            //Задание 1. Вывод ФИО.
            /*
            string name1 = GetFullName();
            string name2 = GetFullName();
            string name3 = GetFullName();
           
            Console.WriteLine(name1 + "\n" + name2 + "\n" + name3); // вывод списка имен вводимых вручную

            GetFullNameList();                                      //вывод готовго списка имен
            Console.ReadLine();
            Console.Clear();

            //Задание 2. Ввод чисел и определение их суммы
            Console.WriteLine("Введите несколько цифр разделяемых пробелом, а я посчитаю их сумму!");
            int a = GetSumString();
            Console.WriteLine($"Сумма чисел Вашей строки: {a}!");
            Console.ReadLine();
            Console.Clear();

            //Задание 3. Времена года.
            Console.WriteLine("Введите число от 1 до 12, а я скажу Вам что это за время года!");
            string b = GuesSeason().ToString();
            Console.WriteLine($"Это время года {b}!");
            Console.WriteLine($"А по русски будет {RusSeason(b)}!");
            Console.ReadLine();
            Console.Clear();
            */
            //Задание 4. Написать программу вычисляющую число Фибоначчи.
            Console.WriteLine("Введите целое число, а я посчитаю число Фибоначчи введенного Вами значения");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine($"Число Фибоначи будет {Fibonachi(c)}!");
            Console.ReadLine();
            Console.Clear();



        } 
    }
}
