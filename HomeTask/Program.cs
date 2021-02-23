using System;

namespace HomeTask2
{
    class Program
{
    
        enum month
    {
        Январь,
        Февраль,
        Март,
        Апрель,
        Май,
        Июнь,
        Июль,
        Август,
        Сентябрь,
        Октябрь,
        Ноябрь,
        Декабрь
    }
  
        [Flags]
        enum dayofweek
        {
            Понедельник = 0b_0000001,
            Вторник = 0b_0000010,
            Среда = 0b_0000100,
            Четверг = 0b_0001000,
            Пятница = 0b_0010000,
            Суббота = 0b_0100000,
            Воскресение = 0b_1000000,
        }

        static void Main(string[] args)
        {
            
            //Задание 1. Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру.

            Console.WriteLine($"Введи минимальную температуру за {DateTime.Now}:");
            double minTemp = double.Parse(Console.ReadLine());
            Console.WriteLine($"Введи максимальную температуру за {DateTime.Now}:");
            double maxTemp = double.Parse(Console.ReadLine());
            double midTemp = (minTemp + maxTemp) / 2;
            Console.WriteLine($"Среднесуточная температура за {DateTime.Now} составляет {midTemp} градусов Цельсия");
            Console.ReadLine();
            Console.Clear();

            //Задание 2. Запросить у пользователя порядковый номер текущего месяца и вывести его значение.
            
            Console.WriteLine("Пожалуйста, введите число от 1 до 12, а я скажу к какому месяцу оно соответствует!");
            int usermonth = int.Parse(Console.ReadLine());
            if (1 <=usermonth && usermonth <= 12)
            {
                Console.WriteLine($"Это месяц {(month)usermonth - 1}!");
            }
            else
            {
                Console.WriteLine("Вы ввели число не в ходящее в указанный ранее диапазон, либо дробное или отрицательные числа, пожулуйста перезапустите программу и попробуйте снова!");
            }
            Console.ReadLine();
            Console.Clear();

            //Задание 3. Определить, является ли введенное пользователем число четным.

            Console.WriteLine("Введите число, а я скажу Вам, является ли оно четным");
            int userNumber = int.Parse(Console.ReadLine());
            if(userNumber %2 == 0)
            {
                Console.WriteLine($"{userNumber} четное число!");
            }
            else
            {
                Console.WriteLine($"{userNumber} не четное число!");
            }
            Console.ReadLine();
            Console.Clear();

            //Задание 4. Программа по созданию чека из магазина.

            Console.WriteLine("Привет, введите название магазина, трех товаров и их стоимость, а я выведу Вам чек с указанием общей суммы и 5% скидки!");
            Console.WriteLine("Введите название магазина:");
            string magName = Console.ReadLine();
            Console.WriteLine("Введите название 1го товара:");
            string item1 = Console.ReadLine();
            Console.WriteLine("Введите цену 1го товара:");
            float price1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите название 2го товара:");
            string item2 = Console.ReadLine();
            Console.WriteLine("Введите цену 2го товара:");
            float price2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите название 3го товара:");
            string item3 = Console.ReadLine();
            Console.WriteLine("Введите цену 3го товара:");
            float price3 = float.Parse(Console.ReadLine());
            float sumprice = price1 + price2 + price3;
            float discount = (sumprice * 5) / 100;                                      // не смог разобраться с округлением чисел до 2х знаков после запятой
            float lastsum = sumprice - discount;
            
            Console.WriteLine(new string('=', 30));
            Console.WriteLine(       $"ООО {magName}"       );
            Console.WriteLine(        "Кассовый чек"        );
            Console.WriteLine($"{item1}------------{price1}");
            Console.WriteLine($"{item2}------------{price2}");
            Console.WriteLine($"{item3}------------{price3}");
            Console.WriteLine(new string('=', 30));
            Console.WriteLine($"Итого:-----------{sumprice}");
            Console.WriteLine($"Скидка 5% -------{discount}");
            Console.WriteLine(new string('=', 30));
            Console.WriteLine($"Итого со скидкой--{lastsum}");
            Console.WriteLine(new string('=', 30));
            Console.WriteLine("Спасибо за покупку!");
            Console.WriteLine(DateTime.Now);
            Console.ReadLine();
            Console.Clear();


            //Задание 5. Если пользователь указал месяц из зимнего периода, а средняя температура > 0, вывести сообщение "Дождливая зима".

            if (usermonth == 1 || usermonth == 2 || usermonth == 12 && midTemp > 0)
            {
                Console.WriteLine("Дождливая зима!");
            }
            Console.ReadLine();
            Console.Clear();

            //Задание 6. Закрепление битовых масок.
            
            dayofweek alldays = dayofweek.Понедельник | dayofweek.Вторник | dayofweek.Среда | dayofweek.Четверг | dayofweek.Пятница | dayofweek.Суббота | dayofweek.Воскресение;
            dayofweek fourdays = dayofweek.Вторник | dayofweek.Среда | dayofweek.Четверг | dayofweek.Пятница;
            dayofweek office1 = (dayofweek)0b_0011110;
            dayofweek office2 = (dayofweek)0b_1111111;

            dayofweek alldayswork = office1 & alldays;
            dayofweek fourdayswork = office1 & fourdays;

            dayofweek alldayswork2 = office2 & alldays;
            dayofweek fourdayswork2 = office2 & fourdays;

            bool isalldayswork = alldays == alldayswork;
            bool isfourdayswork = fourdays == fourdayswork;
            Console.WriteLine($"Рабочие дни первого офиса {office1}");

            bool isalldayswork2 = alldays == alldayswork2;
            bool isfourdayswork2 = fourdays == fourdayswork2;
            Console.WriteLine($"Рабочие дни второго офиса {office2}");

            if (isalldayswork)
            {
                Console.WriteLine("Первый офис работает 7 дней в неделю!");
            }
            else
            {
                if (isfourdayswork)
                {
                    Console.WriteLine("Первый офис работает 4 дня в неделею (Вт. Ср. Чт. Пт.)!");
                }
            }
            if (isalldayswork2)
            {
                Console.WriteLine("Второй офис работает 7 дней в неделю!");
            }
            else
            {
                if (isfourdayswork2)
                {
                    Console.WriteLine("Второй офис работает 4 дня в неделю (Вт. Ср. Чт. Пт.)!");
                }
            }
            Console.ReadLine();
            Console.Clear();
        }
    }
}
